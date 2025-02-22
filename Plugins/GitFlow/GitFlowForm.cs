﻿using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using GitCommands;
using GitExtensions.Plugins.GitFlow.Properties;
using GitExtUtils;
using GitExtUtils.GitUI;
using GitUIPluginInterfaces;
using ResourceManager;

namespace GitExtensions.Plugins.GitFlow
{
    public partial class GitFlowForm : GitExtensionsFormBase
    {
        private readonly TranslationString _gitFlowTooltip = new("A good branch model for your project with Git...");
        private readonly TranslationString _loading = new("Loading...");
        private readonly TranslationString _noBranchExist = new("No {0} branches exist.");

        private readonly GitUIEventArgs _gitUiCommands;

        private Dictionary<string, IReadOnlyList<string>> Branches { get; } = new Dictionary<string, IReadOnlyList<string>>();

        private readonly AsyncLoader _task = new();

        public bool IsRefreshNeeded { get; set; }

        private string? CurrentBranch { get; set; }

        private enum Branch
        {
            feature,
            bugfix,
            hotfix,
            release,
            support
        }

        private static List<string> BranchTypes
        {
            get { return Enum.GetValues(typeof(Branch)).Cast<object>().Select(e => e.ToString()).ToList(); }
        }

        private bool IsGitFlowInitialised
        {
            get
            {
                GitArgumentBuilder args = new("config")
                {
                    "--get",
                    "gitflow.branch.master"
                };
                ExecutionResult exec = _gitUiCommands.GitModule.GitExecutable.Execute(args, throwOnErrorExit: false);
                return exec.ExitedSuccessfully && !string.IsNullOrWhiteSpace(exec.StandardOutput);
            }
        }

        public GitFlowForm(GitUIEventArgs gitUiCommands)
        {
            InitializeComponent();
            InitializeComplete();

            _gitUiCommands = gitUiCommands;

            lblPrefixManage.Text = string.Empty;
            ttGitFlow.SetToolTip(lnkGitFlow, _gitFlowTooltip.Text);

            // To accommodate the translation app
            if (gitUiCommands is null)
            {
                return;
            }

            Init();
        }

        private void Init()
        {
            bool isInitialised = IsGitFlowInitialised;

            btnInit.Visible = !isInitialised;
            gbStart.Enabled = isInitialised;
            gbManage.Enabled = isInitialised;
            lblCaptionHead.Visible = isInitialised;
            lblHead.Visible = isInitialised;

            if (isInitialised)
            {
                IReadOnlyList<string> remotes = _gitUiCommands.GitModule.GetRemoteNames();
                cbRemote.DataSource = remotes;
                btnPull.Enabled = btnPublish.Enabled = remotes.Any();

                cbType.DataSource = BranchTypes;
                List<string> types = new() { string.Empty };
                types.AddRange(BranchTypes);
                cbManageType.DataSource = types;

                cbBasedOn.Checked = false;
                cbBaseBranch.Enabled = false;

                cbPushAfterFinish.Enabled = false;
                cbSquash.Enabled = false;

                LoadBaseBranches();

                DisplayHead();
            }
        }

        private static bool TryExtractBranchFromHead(string currentRef, [NotNullWhen(returnValue: true)] out string? branchType, [NotNullWhen(returnValue: true)] out string? branchName)
        {
            foreach (Branch branch in Enum.GetValues(typeof(Branch)))
            {
                string startRef = branch + "/";
                if (currentRef.StartsWith(startRef))
                {
                    branchType = branch.ToString();
                    branchName = currentRef[startRef.Length..];
                    return true;
                }
            }

            branchType = null;
            branchName = null;
            return false;
        }

        #region Loading Branches
        private void LoadBranches(string branchType)
        {
            cbManageType.Enabled = false;
            btnFinish.Enabled = false;

            cbBranches.DataSource = new List<string> { _loading.Text };
            if (!Branches.ContainsKey(branchType))
            {
                _task.LoadAsync(() => GetBranches(branchType), branches =>
                {
                    Branches.Add(branchType, branches);
                    DisplayBranchData();
                });
            }
            else
            {
                DisplayBranchData();
            }

            btnFinish.Enabled = Branches.Any();
        }

        private IReadOnlyList<string> GetBranches(string typeBranch)
        {
            GitArgumentBuilder args = new("flow") { typeBranch };
            ExecutionResult result = _gitUiCommands.GitModule.GitExecutable.Execute(args);

            if (!result.ExitedSuccessfully || result.StandardOutput is null)
            {
                return Array.Empty<string>();
            }

            return result.StandardOutput
                .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim('*', ' ', '\n', '\r'))
                .ToList();
        }

        private void DisplayBranchData()
        {
            string branchType = cbManageType.SelectedValue.ToString();
            IReadOnlyList<string> branches = Branches[branchType];
            bool isThereABranch = branches.Any();

            cbManageType.Enabled = true;
            cbBranches.DataSource = isThereABranch ? branches : new[] { string.Format(_noBranchExist.Text, branchType) };
            cbBranches.Enabled = isThereABranch;
            if (isThereABranch && CurrentBranch is not null)
            {
                cbBranches.SelectedItem = CurrentBranch;
                CurrentBranch = null;
            }

            btnFinish.Enabled = isThereABranch && (branchType != Branch.support.ToString("G"));
            cbPushAfterFinish.Enabled = isThereABranch && (branchType == Branch.hotfix.ToString("G") || branchType == Branch.release.ToString("G"));
            cbSquash.Enabled = isThereABranch && branchType != Branch.support.ToString("G");
            btnPublish.Enabled = isThereABranch && (branchType != Branch.support.ToString("G"));
            btnPull.Enabled = isThereABranch && (branchType != Branch.support.ToString("G"));
            pnlPull.Enabled = branchType != Branch.support.ToString("G");
        }

        private void LoadBaseBranches()
        {
            string branchType = cbType.SelectedValue.ToString();
            bool manageBaseBranch = branchType != Branch.release.ToString("G");
            pnlBasedOn.Visible = manageBaseBranch;

            if (manageBaseBranch)
            {
                cbBaseBranch.DataSource = GetLocalBranches();
            }

            List<string> GetLocalBranches()
            {
                GitArgumentBuilder args = new("branch");
                return _gitUiCommands.GitModule
                    .GitExecutable.GetOutput(args)
                    .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(e => e.Trim('*', ' ', '\n', '\r'))
                    .ToList();
            }
        }

        #endregion

        #region Run GitFlow commands
        private void btnInit_Click(object sender, EventArgs e)
        {
            GitArgumentBuilder args = new("flow")
            {
                "init",
                "-d"
            };
            if (RunCommand(args))
            {
                Init();
            }
        }

        private void btnStartBranch_Click(object sender, EventArgs e)
        {
            string branchType = cbType.SelectedValue.ToString();
            GitArgumentBuilder args = new("flow")
            {
                branchType,
                "start",
                txtBranchName.Text,
                GetBaseBranch()
            };
            if (RunCommand(args))
            {
                txtBranchName.Text = string.Empty;
                if (cbManageType.SelectedValue.ToString() == branchType)
                {
                    Branches.Remove(branchType);
                    LoadBranches(branchType);
                }
                else
                {
                    Branches.Remove(branchType);
                }
            }
        }

        private string GetBaseBranch()
        {
            string branchType = cbType.SelectedValue.ToString();
            if (branchType == Branch.release.ToString("G"))
            {
                return string.Empty;
            }

            if (branchType == Branch.support.ToString("G"))
            {
                return " HEAD"; // Hoping that's a revision on master (How to get the sha of the selected line in GitExtension?)
            }

            if (!cbBasedOn.Checked)
            {
                return string.Empty;
            }

            return " " + cbBaseBranch.SelectedValue;
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            GitArgumentBuilder args = new("flow")
            {
                cbManageType.SelectedValue.ToString(),
                "publish",
                cbBranches.SelectedValue.ToString()
            };
            RunCommand(args);
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            GitArgumentBuilder args = new("flow")
            {
                cbManageType.SelectedValue.ToString(),
                "pull",
                cbRemote.SelectedValue.ToString(),
                cbBranches.SelectedValue.ToString()
            };
            RunCommand(args);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            GitArgumentBuilder args = new("flow")
            {
                cbManageType.SelectedValue.ToString(),
                "finish",
                { cbPushAfterFinish.Checked, "-p" },
                { cbSquash.Checked, "-S" },
                cbBranches.SelectedValue.ToString()
            };
            RunCommand(args);
        }

        private bool RunCommand(ArgumentString commandText)
        {
            pbResultCommand.Image = DpiUtil.Scale(Resource.StatusHourglass);
            ShowToolTip(pbResultCommand, "running command : git " + commandText);
            ForceRefresh(pbResultCommand);
            lblRunCommand.Text = "git " + commandText;
            ForceRefresh(lblRunCommand);
            txtResult.Text = "running...";
            ForceRefresh(txtResult);

            ExecutionResult result = _gitUiCommands.GitModule.GitExecutable.Execute(commandText, throwOnErrorExit: false);

            IsRefreshNeeded = true;

            ttDebug.RemoveAll();
            ttDebug.SetToolTip(lblDebug, "cmd: git " + commandText + "\n" + "exit code:" + result.ExitCode);

            // TODO Can AllOutput be replaced with StandardOutput?
            string resultText = Regex.Replace(result.AllOutput, @"\r\n?|\n", Environment.NewLine);

            if (result.ExitedSuccessfully)
            {
                pbResultCommand.Image = DpiUtil.Scale(Resource.success);
                ShowToolTip(pbResultCommand, resultText);
                DisplayHead();
            }
            else
            {
                pbResultCommand.Image = DpiUtil.Scale(Resource.error);
                ShowToolTip(pbResultCommand, "error: " + resultText);
            }

            txtResult.Text = resultText;

            return result.ExitedSuccessfully;
        }

        #endregion

        #region GUI interactions

        private static void ForceRefresh(Control c)
        {
            c.Invalidate();
            c.Update();
            c.Refresh();
        }

        private void ShowToolTip(Control c, string msg)
        {
            ttCommandResult.RemoveAll();
            ttCommandResult.SetToolTip(c, msg);
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            lblPrefixName.Text = cbType.SelectedValue + "/";
            LoadBaseBranches();
        }

        private void cbManageType_SelectedValueChanged(object sender, EventArgs e)
        {
            string branchType = cbManageType.SelectedValue.ToString();
            lblPrefixManage.Text = branchType + "/";
            if (!string.IsNullOrWhiteSpace(branchType))
            {
                pnlManageBranch.Enabled = true;
                LoadBranches(branchType);
            }
            else
            {
                pnlManageBranch.Enabled = false;
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbBasedOn_CheckedChanged(object sender, EventArgs e)
        {
            cbBaseBranch.Enabled = cbBasedOn.Checked;
        }

        private void lnkGitFlow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OsShellUtil.OpenUrlInDefaultBrowser("https://github.com/nvie/gitflow");
        }

        private void DisplayHead()
        {
            GitArgumentBuilder args = new("symbolic-ref")
            {
                "--quiet",
                "HEAD"
            };
            ExecutionResult result = _gitUiCommands.GitModule.GitExecutable.Execute(args, throwOnErrorExit: false);

            string head = result.ExitedSuccessfully
                ? result.StandardOutput.Trim('*', ' ', '\n', '\r')
                : "";

            lblHead.Text = head;
            string currentRef = head.RemovePrefix(GitRefName.RefsHeadsPrefix);

            if (TryExtractBranchFromHead(currentRef, out string branchTypes, out string branchName))
            {
                cbManageType.SelectedItem = branchTypes;
                CurrentBranch = branchName;
            }
        }
    }
}
