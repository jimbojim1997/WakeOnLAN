namespace WakeOnLAN
{
    partial class FrmMain
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
            if (disposing && (components != null))
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
            this.clbTargets = new System.Windows.Forms.CheckedListBox();
            this.msFrmMain = new System.Windows.Forms.MenuStrip();
            this.btnWakeTarget = new System.Windows.Forms.Button();
            this.gbTargetInfo = new System.Windows.Forms.GroupBox();
            this.tbBroadcastAddress = new System.Windows.Forms.TextBox();
            this.mtbMACAddress = new System.Windows.Forms.MaskedTextBox();
            this.tbTargetName = new System.Windows.Forms.TextBox();
            this.lblBroadcastAddress = new System.Windows.Forms.Label();
            this.lblMACAddress = new System.Windows.Forms.Label();
            this.lblTargetName = new System.Windows.Forms.Label();
            this.btnDeleteTarget = new System.Windows.Forms.Button();
            this.btnUpdateTarget = new System.Windows.Forms.Button();
            this.btnNewTarget = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.nudPacketsToSend = new System.Windows.Forms.NumericUpDown();
            this.lblPacketsToSend = new System.Windows.Forms.Label();
            this.gbTargetInfo.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPacketsToSend)).BeginInit();
            this.SuspendLayout();
            // 
            // clbTargets
            // 
            this.clbTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTargets.FormattingEnabled = true;
            this.clbTargets.Location = new System.Drawing.Point(12, 27);
            this.clbTargets.Name = "clbTargets";
            this.clbTargets.Size = new System.Drawing.Size(305, 244);
            this.clbTargets.TabIndex = 0;
            this.clbTargets.SelectedIndexChanged += new System.EventHandler(this.clbTargets_SelectedIndexChanged);
            // 
            // msFrmMain
            // 
            this.msFrmMain.Location = new System.Drawing.Point(0, 0);
            this.msFrmMain.Name = "msFrmMain";
            this.msFrmMain.Size = new System.Drawing.Size(569, 24);
            this.msFrmMain.TabIndex = 1;
            this.msFrmMain.Text = "menuStrip1";
            // 
            // btnWakeTarget
            // 
            this.btnWakeTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWakeTarget.Location = new System.Drawing.Point(12, 285);
            this.btnWakeTarget.Name = "btnWakeTarget";
            this.btnWakeTarget.Size = new System.Drawing.Size(73, 23);
            this.btnWakeTarget.TabIndex = 1;
            this.btnWakeTarget.Text = "Wake";
            this.btnWakeTarget.UseVisualStyleBackColor = true;
            this.btnWakeTarget.Click += new System.EventHandler(this.btnWakeTarget_Click);
            // 
            // gbTargetInfo
            // 
            this.gbTargetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTargetInfo.Controls.Add(this.tbBroadcastAddress);
            this.gbTargetInfo.Controls.Add(this.mtbMACAddress);
            this.gbTargetInfo.Controls.Add(this.tbTargetName);
            this.gbTargetInfo.Controls.Add(this.lblBroadcastAddress);
            this.gbTargetInfo.Controls.Add(this.lblMACAddress);
            this.gbTargetInfo.Controls.Add(this.lblTargetName);
            this.gbTargetInfo.Controls.Add(this.btnDeleteTarget);
            this.gbTargetInfo.Controls.Add(this.btnUpdateTarget);
            this.gbTargetInfo.Controls.Add(this.btnNewTarget);
            this.gbTargetInfo.Location = new System.Drawing.Point(323, 27);
            this.gbTargetInfo.Name = "gbTargetInfo";
            this.gbTargetInfo.Size = new System.Drawing.Size(234, 131);
            this.gbTargetInfo.TabIndex = 12;
            this.gbTargetInfo.TabStop = false;
            this.gbTargetInfo.Text = "Target";
            // 
            // tbBroadcastAddress
            // 
            this.tbBroadcastAddress.Location = new System.Drawing.Point(108, 100);
            this.tbBroadcastAddress.Name = "tbBroadcastAddress";
            this.tbBroadcastAddress.Size = new System.Drawing.Size(120, 20);
            this.tbBroadcastAddress.TabIndex = 7;
            // 
            // mtbMACAddress
            // 
            this.mtbMACAddress.Location = new System.Drawing.Point(108, 74);
            this.mtbMACAddress.Mask = ">aa\\:aa\\:aa\\:aa\\:aa\\:aa";
            this.mtbMACAddress.Name = "mtbMACAddress";
            this.mtbMACAddress.Size = new System.Drawing.Size(120, 20);
            this.mtbMACAddress.TabIndex = 6;
            // 
            // tbTargetName
            // 
            this.tbTargetName.Location = new System.Drawing.Point(108, 48);
            this.tbTargetName.Name = "tbTargetName";
            this.tbTargetName.Size = new System.Drawing.Size(120, 20);
            this.tbTargetName.TabIndex = 5;
            // 
            // lblBroadcastAddress
            // 
            this.lblBroadcastAddress.AutoSize = true;
            this.lblBroadcastAddress.Location = new System.Drawing.Point(6, 103);
            this.lblBroadcastAddress.Name = "lblBroadcastAddress";
            this.lblBroadcastAddress.Size = new System.Drawing.Size(96, 13);
            this.lblBroadcastAddress.TabIndex = 17;
            this.lblBroadcastAddress.Text = "Broadcast Address";
            // 
            // lblMACAddress
            // 
            this.lblMACAddress.AutoSize = true;
            this.lblMACAddress.Location = new System.Drawing.Point(6, 77);
            this.lblMACAddress.Name = "lblMACAddress";
            this.lblMACAddress.Size = new System.Drawing.Size(71, 13);
            this.lblMACAddress.TabIndex = 16;
            this.lblMACAddress.Text = "MAC Address";
            // 
            // lblTargetName
            // 
            this.lblTargetName.AutoSize = true;
            this.lblTargetName.Location = new System.Drawing.Point(6, 51);
            this.lblTargetName.Name = "lblTargetName";
            this.lblTargetName.Size = new System.Drawing.Size(35, 13);
            this.lblTargetName.TabIndex = 15;
            this.lblTargetName.Text = "Name";
            // 
            // btnDeleteTarget
            // 
            this.btnDeleteTarget.Location = new System.Drawing.Point(158, 19);
            this.btnDeleteTarget.Name = "btnDeleteTarget";
            this.btnDeleteTarget.Size = new System.Drawing.Size(70, 23);
            this.btnDeleteTarget.TabIndex = 4;
            this.btnDeleteTarget.Text = "Delete";
            this.btnDeleteTarget.UseVisualStyleBackColor = true;
            this.btnDeleteTarget.Click += new System.EventHandler(this.btnDeleteTarget_Click);
            // 
            // btnUpdateTarget
            // 
            this.btnUpdateTarget.Location = new System.Drawing.Point(82, 19);
            this.btnUpdateTarget.Name = "btnUpdateTarget";
            this.btnUpdateTarget.Size = new System.Drawing.Size(70, 23);
            this.btnUpdateTarget.TabIndex = 3;
            this.btnUpdateTarget.Text = "Update";
            this.btnUpdateTarget.UseVisualStyleBackColor = true;
            this.btnUpdateTarget.Click += new System.EventHandler(this.btnUpdateTarget_Click);
            // 
            // btnNewTarget
            // 
            this.btnNewTarget.Location = new System.Drawing.Point(6, 19);
            this.btnNewTarget.Name = "btnNewTarget";
            this.btnNewTarget.Size = new System.Drawing.Size(70, 23);
            this.btnNewTarget.TabIndex = 2;
            this.btnNewTarget.Text = "New";
            this.btnNewTarget.UseVisualStyleBackColor = true;
            this.btnNewTarget.Click += new System.EventHandler(this.btnNewTarget_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.nudPacketsToSend);
            this.gbOptions.Controls.Add(this.lblPacketsToSend);
            this.gbOptions.Location = new System.Drawing.Point(323, 164);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(234, 110);
            this.gbOptions.TabIndex = 13;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // nudPacketsToSend
            // 
            this.nudPacketsToSend.Location = new System.Drawing.Point(186, 19);
            this.nudPacketsToSend.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPacketsToSend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPacketsToSend.Name = "nudPacketsToSend";
            this.nudPacketsToSend.Size = new System.Drawing.Size(42, 20);
            this.nudPacketsToSend.TabIndex = 8;
            this.nudPacketsToSend.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPacketsToSend
            // 
            this.lblPacketsToSend.AutoSize = true;
            this.lblPacketsToSend.Location = new System.Drawing.Point(3, 21);
            this.lblPacketsToSend.Name = "lblPacketsToSend";
            this.lblPacketsToSend.Size = new System.Drawing.Size(84, 13);
            this.lblPacketsToSend.TabIndex = 0;
            this.lblPacketsToSend.Text = "Packets to send";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 313);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbTargetInfo);
            this.Controls.Add(this.btnWakeTarget);
            this.Controls.Add(this.clbTargets);
            this.Controls.Add(this.msFrmMain);
            this.MainMenuStrip = this.msFrmMain;
            this.MinimumSize = new System.Drawing.Size(352, 343);
            this.Name = "FrmMain";
            this.Text = "Wake On LAN";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbTargetInfo.ResumeLayout(false);
            this.gbTargetInfo.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPacketsToSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTargets;
        private System.Windows.Forms.MenuStrip msFrmMain;
        private System.Windows.Forms.Button btnWakeTarget;
        private System.Windows.Forms.GroupBox gbTargetInfo;
        private System.Windows.Forms.TextBox tbBroadcastAddress;
        private System.Windows.Forms.MaskedTextBox mtbMACAddress;
        private System.Windows.Forms.TextBox tbTargetName;
        private System.Windows.Forms.Label lblBroadcastAddress;
        private System.Windows.Forms.Label lblMACAddress;
        private System.Windows.Forms.Label lblTargetName;
        private System.Windows.Forms.Button btnDeleteTarget;
        private System.Windows.Forms.Button btnUpdateTarget;
        private System.Windows.Forms.Button btnNewTarget;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.NumericUpDown nudPacketsToSend;
        private System.Windows.Forms.Label lblPacketsToSend;
    }
}

