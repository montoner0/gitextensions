﻿namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    partial class DetailedSettingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components is not null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PushWindowGB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkRemotesFromServer = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxEmailSettings = new System.Windows.Forms.GroupBox();
            this.tlpnlEmailSettings = new System.Windows.Forms.TableLayoutPanel();
            this.SmtpServer = new System.Windows.Forms.TextBox();
            this.lblSmtpServerPort = new System.Windows.Forms.Label();
            this.chkUseSSL = new System.Windows.Forms.CheckBox();
            this.SmtpServerPort = new System.Windows.Forms.TextBox();
            this.lblSmtpServerName = new System.Windows.Forms.Label();
            this.mergeWindowGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addLogMessages = new System.Windows.Forms.CheckBox();
            this.nbMessages = new System.Windows.Forms.TextBox();
            this.PushWindowGB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxEmailSettings.SuspendLayout();
            this.tlpnlEmailSettings.SuspendLayout();
            this.mergeWindowGroup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PushWindowGB
            // 
            this.PushWindowGB.AutoSize = true;
            this.PushWindowGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PushWindowGB.Controls.Add(this.tableLayoutPanel1);
            this.PushWindowGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PushWindowGB.Location = new System.Drawing.Point(3, 3);
            this.PushWindowGB.Name = "PushWindowGB";
            this.PushWindowGB.Padding = new System.Windows.Forms.Padding(8);
            this.PushWindowGB.Size = new System.Drawing.Size(1318, 52);
            this.PushWindowGB.TabIndex = 0;
            this.PushWindowGB.TabStop = false;
            this.PushWindowGB.Text = "Push window";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkRemotesFromServer, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1302, 23);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkRemotesFromServer
            // 
            this.chkRemotesFromServer.AutoSize = true;
            this.chkRemotesFromServer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkRemotesFromServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkRemotesFromServer.Location = new System.Drawing.Point(3, 3);
            this.chkRemotesFromServer.Name = "chkRemotesFromServer";
            this.chkRemotesFromServer.Size = new System.Drawing.Size(1296, 17);
            this.chkRemotesFromServer.TabIndex = 0;
            this.chkRemotesFromServer.Text = "Get remote branches directly from the remote";
            this.chkRemotesFromServer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.groupBoxEmailSettings, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.mergeWindowGroup, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PushWindowGB, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1324, 873);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxEmailSettings
            // 
            this.groupBoxEmailSettings.AutoSize = true;
            this.groupBoxEmailSettings.Controls.Add(this.tlpnlEmailSettings);
            this.groupBoxEmailSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEmailSettings.Location = new System.Drawing.Point(3, 128);
            this.groupBoxEmailSettings.Name = "groupBoxEmailSettings";
            this.groupBoxEmailSettings.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxEmailSettings.Size = new System.Drawing.Size(1318, 104);
            this.groupBoxEmailSettings.TabIndex = 2;
            this.groupBoxEmailSettings.TabStop = false;
            this.groupBoxEmailSettings.Text = "Email settings for sending patches";
            // 
            // tlpnlEmailSettings
            // 
            this.tlpnlEmailSettings.AutoSize = true;
            this.tlpnlEmailSettings.ColumnCount = 3;
            this.tlpnlEmailSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpnlEmailSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpnlEmailSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpnlEmailSettings.Controls.Add(this.SmtpServer, 2, 0);
            this.tlpnlEmailSettings.Controls.Add(this.lblSmtpServerPort, 0, 1);
            this.tlpnlEmailSettings.Controls.Add(this.chkUseSSL, 0, 2);
            this.tlpnlEmailSettings.Controls.Add(this.SmtpServerPort, 2, 1);
            this.tlpnlEmailSettings.Controls.Add(this.lblSmtpServerName, 0, 0);
            this.tlpnlEmailSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpnlEmailSettings.Location = new System.Drawing.Point(8, 21);
            this.tlpnlEmailSettings.Name = "tlpnlEmailSettings";
            this.tlpnlEmailSettings.RowCount = 3;
            this.tlpnlEmailSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlEmailSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlEmailSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpnlEmailSettings.Size = new System.Drawing.Size(1302, 75);
            this.tlpnlEmailSettings.TabIndex = 0;
            // 
            // SmtpServer
            // 
            this.SmtpServer.Location = new System.Drawing.Point(117, 3);
            this.SmtpServer.Name = "SmtpServer";
            this.SmtpServer.Size = new System.Drawing.Size(179, 20);
            this.SmtpServer.TabIndex = 0;
            // 
            // lblSmtpServerPort
            // 
            this.lblSmtpServerPort.AutoSize = true;
            this.lblSmtpServerPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSmtpServerPort.Location = new System.Drawing.Point(3, 26);
            this.lblSmtpServerPort.Name = "lblSmtpServerPort";
            this.lblSmtpServerPort.Size = new System.Drawing.Size(108, 26);
            this.lblSmtpServerPort.TabIndex = 1;
            this.lblSmtpServerPort.Text = "Port";
            this.lblSmtpServerPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkUseSSL
            // 
            this.chkUseSSL.AutoSize = true;
            this.chkUseSSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUseSSL.Location = new System.Drawing.Point(3, 55);
            this.chkUseSSL.Name = "chkUseSSL";
            this.chkUseSSL.Size = new System.Drawing.Size(108, 17);
            this.chkUseSSL.TabIndex = 3;
            this.chkUseSSL.Text = "Use SSL/TLS";
            this.chkUseSSL.UseVisualStyleBackColor = true;
            this.chkUseSSL.CheckedChanged += new System.EventHandler(this.chkUseSSL_CheckedChanged);
            // 
            // SmtpServerPort
            // 
            this.SmtpServerPort.Location = new System.Drawing.Point(117, 29);
            this.SmtpServerPort.Name = "SmtpServerPort";
            this.SmtpServerPort.Size = new System.Drawing.Size(49, 20);
            this.SmtpServerPort.TabIndex = 2;
            this.SmtpServerPort.Text = "587";
            // 
            // lblSmtpServerName
            // 
            this.lblSmtpServerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSmtpServerName.AutoSize = true;
            this.lblSmtpServerName.Location = new System.Drawing.Point(3, 6);
            this.lblSmtpServerName.Name = "lblSmtpServerName";
            this.lblSmtpServerName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblSmtpServerName.Size = new System.Drawing.Size(108, 13);
            this.lblSmtpServerName.TabIndex = 0;
            this.lblSmtpServerName.Text = "SMTP server name";
            this.lblSmtpServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mergeWindowGroup
            // 
            this.mergeWindowGroup.AutoSize = true;
            this.mergeWindowGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mergeWindowGroup.Controls.Add(this.tableLayoutPanel4);
            this.mergeWindowGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.mergeWindowGroup.Location = new System.Drawing.Point(3, 61);
            this.mergeWindowGroup.Name = "mergeWindowGroup";
            this.mergeWindowGroup.Padding = new System.Windows.Forms.Padding(8);
            this.mergeWindowGroup.Size = new System.Drawing.Size(1318, 61);
            this.mergeWindowGroup.TabIndex = 1;
            this.mergeWindowGroup.TabStop = false;
            this.mergeWindowGroup.Text = "Merge window";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1302, 32);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.addLogMessages);
            this.flowLayoutPanel1.Controls.Add(this.nbMessages);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addLogMessages
            // 
            this.addLogMessages.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addLogMessages.AutoSize = true;
            this.addLogMessages.Location = new System.Drawing.Point(3, 4);
            this.addLogMessages.Name = "addLogMessages";
            this.addLogMessages.Size = new System.Drawing.Size(112, 17);
            this.addLogMessages.TabIndex = 0;
            this.addLogMessages.Text = "Add log messages";
            this.addLogMessages.UseVisualStyleBackColor = true;
            // 
            // nbMessages
            // 
            this.nbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbMessages.Location = new System.Drawing.Point(121, 3);
            this.nbMessages.Name = "nbMessages";
            this.nbMessages.Size = new System.Drawing.Size(51, 20);
            this.nbMessages.TabIndex = 1;
            this.nbMessages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetailedSettingsPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "DetailedSettingsPage";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1340, 889);
            this.Text = "Detailed";
            this.PushWindowGB.ResumeLayout(false);
            this.PushWindowGB.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxEmailSettings.ResumeLayout(false);
            this.groupBoxEmailSettings.PerformLayout();
            this.tlpnlEmailSettings.ResumeLayout(false);
            this.tlpnlEmailSettings.PerformLayout();
            this.mergeWindowGroup.ResumeLayout(false);
            this.mergeWindowGroup.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PushWindowGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkRemotesFromServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox mergeWindowGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox addLogMessages;
        private System.Windows.Forms.TextBox nbMessages;
        private System.Windows.Forms.GroupBox groupBoxEmailSettings;
        private System.Windows.Forms.TableLayoutPanel tlpnlEmailSettings;
        private System.Windows.Forms.TextBox SmtpServer;
        private System.Windows.Forms.Label lblSmtpServerPort;
        private System.Windows.Forms.CheckBox chkUseSSL;
        private System.Windows.Forms.TextBox SmtpServerPort;
        private System.Windows.Forms.Label lblSmtpServerName;
    }
}
