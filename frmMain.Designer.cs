﻿namespace Authentiqr.NET
{
	partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLockUnlock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = global::Authentiqr.NET.Resources.Padlock;
            this.notifyIcon.Text = "Authentiqr.NET";
            this.notifyIcon.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddAccount,
            this.toolStripMenuItem2,
            this.mnuLockUnlock,
            this.mnuExit});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(153, 98);
            // 
            // mnuAddAccount
            // 
            this.mnuAddAccount.Name = "mnuAddAccount";
            this.mnuAddAccount.Size = new System.Drawing.Size(152, 22);
            this.mnuAddAccount.Text = "Add Account";
            this.mnuAddAccount.Click += new System.EventHandler(this.mnuAddAccount_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuLockUnlock
            // 
            this.mnuLockUnlock.Name = "mnuLockUnlock";
            this.mnuLockUnlock.Size = new System.Drawing.Size(152, 22);
            this.mnuLockUnlock.Text = "Unlock";
            this.mnuLockUnlock.Click += new System.EventHandler(this.mnuLockUnlock_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "facebook.png");
            this.imageList.Images.SetKeyName(1, "google-0.png");
            this.imageList.Images.SetKeyName(2, "Microsoft-16.png");
            this.imageList.Images.SetKeyName(3, "github-0.png");
            this.imageList.Images.SetKeyName(4, "Dropbox-16.png");
            this.imageList.Images.SetKeyName(5, "uplay.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 76);
            this.Icon = global::Authentiqr.NET.Resources.Padlock;
            this.Location = new System.Drawing.Point(-1000, 0);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.Text = "Authentiqr.NET";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.Timer tmrMain;
		private System.Windows.Forms.ToolStripMenuItem mnuAddAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuLockUnlock;
        private System.Windows.Forms.ImageList imageList;
    }
}

