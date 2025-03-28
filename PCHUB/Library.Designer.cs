namespace PCHUB
{
    partial class Library
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            ZAPRET = new Button();
            CMD = new Button();
            CONTROLPANEL = new Button();
            REGEDIT = new Button();
            TaskMGR = new Button();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            TxtWriter = new Button();
            Taskkiller = new Button();
            FileExplorer = new Button();
            ProccesHacker = new Button();
            AddLocalUser = new Button();
            ExplorerPP = new Button();
            WindowsSettings = new Button();
            buildhelp = new Label();
            PowerMgr = new Button();
            TaskMgrControl = new Button();
            HostsFile = new Button();
            PowerShellPolicyManager = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ZAPRET
            // 
            ZAPRET.Cursor = Cursors.Hand;
            ZAPRET.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZAPRET.Location = new Point(576, 368);
            ZAPRET.Name = "ZAPRET";
            ZAPRET.Size = new Size(100, 70);
            ZAPRET.TabIndex = 0;
            ZAPRET.Text = "ZAPRET for Russia";
            ZAPRET.UseVisualStyleBackColor = true;
            ZAPRET.Click += ZAPRET_Click;
            // 
            // CMD
            // 
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Consolas", 9F);
            CMD.Location = new Point(548, 85);
            CMD.Name = "CMD";
            CMD.Size = new Size(128, 50);
            CMD.TabIndex = 2;
            CMD.Text = "CMD ";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
            // 
            // CONTROLPANEL
            // 
            CONTROLPANEL.Cursor = Cursors.Hand;
            CONTROLPANEL.Font = new Font("Consolas", 9F);
            CONTROLPANEL.Location = new Point(414, 85);
            CONTROLPANEL.Name = "CONTROLPANEL";
            CONTROLPANEL.Size = new Size(128, 50);
            CONTROLPANEL.TabIndex = 4;
            CONTROLPANEL.Text = "Control Panel 🛂";
            CONTROLPANEL.UseVisualStyleBackColor = true;
            CONTROLPANEL.Click += CONTROLPANEL_Click;
            // 
            // REGEDIT
            // 
            REGEDIT.Cursor = Cursors.Hand;
            REGEDIT.Font = new Font("Consolas", 9F);
            REGEDIT.Location = new Point(280, 85);
            REGEDIT.Name = "REGEDIT";
            REGEDIT.Size = new Size(128, 50);
            REGEDIT.TabIndex = 5;
            REGEDIT.Text = "REGEDIT ®";
            REGEDIT.UseVisualStyleBackColor = true;
            REGEDIT.Click += REGEDIT_Click;
            // 
            // TaskMGR
            // 
            TaskMGR.Cursor = Cursors.Hand;
            TaskMGR.Font = new Font("Consolas", 9F);
            TaskMGR.Location = new Point(146, 85);
            TaskMGR.Name = "TaskMGR";
            TaskMGR.Size = new Size(128, 50);
            TaskMGR.TabIndex = 6;
            TaskMGR.Text = "Task Manager 💻";
            TaskMGR.UseVisualStyleBackColor = true;
            TaskMGR.Click += RESOURCEMONITOR_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { themeToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(691, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, purpleToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(55, 20);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(108, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(108, 22);
            purpleToolStripMenuItem.Text = "Purple";
            purpleToolStripMenuItem.Click += purpleToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(57, 20);
            quitToolStripMenuItem.Text = "To Hub";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // TxtWriter
            // 
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Consolas", 9F);
            TxtWriter.Location = new Point(12, 85);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(128, 50);
            TxtWriter.TabIndex = 10;
            TxtWriter.Text = "Writer ✒";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // Taskkiller
            // 
            Taskkiller.Cursor = Cursors.Hand;
            Taskkiller.Font = new Font("Consolas", 9F);
            Taskkiller.Location = new Point(414, 29);
            Taskkiller.Margin = new Padding(4, 3, 4, 3);
            Taskkiller.Name = "Taskkiller";
            Taskkiller.Size = new Size(128, 50);
            Taskkiller.TabIndex = 18;
            Taskkiller.Text = "TaskKill 🔪";
            Taskkiller.UseVisualStyleBackColor = true;
            Taskkiller.Click += Taskkiller_Click;
            // 
            // FileExplorer
            // 
            FileExplorer.Font = new Font("Consolas", 9F);
            FileExplorer.Location = new Point(548, 29);
            FileExplorer.Name = "FileExplorer";
            FileExplorer.Size = new Size(128, 50);
            FileExplorer.TabIndex = 23;
            FileExplorer.Text = "File Explorer";
            FileExplorer.UseVisualStyleBackColor = true;
            FileExplorer.Click += FileExplorer_Click;
            // 
            // ProccesHacker
            // 
            ProccesHacker.Cursor = Cursors.Hand;
            ProccesHacker.Font = new Font("Consolas", 9F);
            ProccesHacker.Location = new Point(280, 29);
            ProccesHacker.Name = "ProccesHacker";
            ProccesHacker.Size = new Size(128, 50);
            ProccesHacker.TabIndex = 30;
            ProccesHacker.Text = "Procces Hacker 💀";
            ProccesHacker.UseVisualStyleBackColor = true;
            ProccesHacker.Click += button1_Click;
            // 
            // AddLocalUser
            // 
            AddLocalUser.Cursor = Cursors.Hand;
            AddLocalUser.Font = new Font("Consolas", 9F);
            AddLocalUser.Location = new Point(12, 29);
            AddLocalUser.Name = "AddLocalUser";
            AddLocalUser.Size = new Size(128, 50);
            AddLocalUser.TabIndex = 32;
            AddLocalUser.Text = "Add Local User 👥";
            AddLocalUser.UseVisualStyleBackColor = true;
            AddLocalUser.Click += LocalUser_Click;
            // 
            // ExplorerPP
            // 
            ExplorerPP.Cursor = Cursors.Hand;
            ExplorerPP.Font = new Font("Consolas", 9F);
            ExplorerPP.Location = new Point(146, 29);
            ExplorerPP.Name = "ExplorerPP";
            ExplorerPP.Size = new Size(128, 50);
            ExplorerPP.TabIndex = 34;
            ExplorerPP.Text = "Explorer++";
            ExplorerPP.UseVisualStyleBackColor = true;
            ExplorerPP.Click += ExplorerPP_Click;
            // 
            // WindowsSettings
            // 
            WindowsSettings.Cursor = Cursors.Hand;
            WindowsSettings.Font = new Font("Consolas", 9F);
            WindowsSettings.Location = new Point(12, 141);
            WindowsSettings.Margin = new Padding(4, 3, 4, 3);
            WindowsSettings.Name = "WindowsSettings";
            WindowsSettings.Size = new Size(128, 50);
            WindowsSettings.TabIndex = 35;
            WindowsSettings.Text = "Windows Settings ⚙";
            WindowsSettings.UseVisualStyleBackColor = true;
            WindowsSettings.Click += WindowsSettings_Click;
            // 
            // buildhelp
            // 
            buildhelp.AutoSize = true;
            buildhelp.BackColor = Color.Gray;
            buildhelp.Cursor = Cursors.Hand;
            buildhelp.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buildhelp.ForeColor = Color.White;
            buildhelp.Location = new Point(0, 417);
            buildhelp.Margin = new Padding(4, 0, 4, 0);
            buildhelp.Name = "buildhelp";
            buildhelp.Size = new Size(126, 20);
            buildhelp.TabIndex = 36;
            buildhelp.Text = "BUILD: 3/26/2025";
            buildhelp.Click += buildhelp_Click;
            // 
            // PowerMgr
            // 
            PowerMgr.Cursor = Cursors.Hand;
            PowerMgr.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PowerMgr.Location = new Point(146, 141);
            PowerMgr.Margin = new Padding(4, 3, 4, 3);
            PowerMgr.Name = "PowerMgr";
            PowerMgr.Size = new Size(128, 50);
            PowerMgr.TabIndex = 37;
            PowerMgr.Text = "Power \r\nmanagement ⚡";
            PowerMgr.UseVisualStyleBackColor = true;
            PowerMgr.Click += PowerMgr_Click;
            // 
            // TaskMgrControl
            // 
            TaskMgrControl.Cursor = Cursors.Hand;
            TaskMgrControl.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskMgrControl.Location = new Point(280, 141);
            TaskMgrControl.Margin = new Padding(4, 3, 4, 3);
            TaskMgrControl.Name = "TaskMgrControl";
            TaskMgrControl.Size = new Size(128, 50);
            TaskMgrControl.TabIndex = 38;
            TaskMgrControl.Text = "TaskMgr Control";
            TaskMgrControl.UseVisualStyleBackColor = true;
            TaskMgrControl.Click += TaskMgrControl_Click;
            // 
            // HostsFile
            // 
            HostsFile.Cursor = Cursors.Hand;
            HostsFile.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HostsFile.Location = new Point(416, 141);
            HostsFile.Margin = new Padding(4, 3, 4, 3);
            HostsFile.Name = "HostsFile";
            HostsFile.Size = new Size(128, 50);
            HostsFile.TabIndex = 39;
            HostsFile.Text = "HostsFile";
            HostsFile.UseVisualStyleBackColor = true;
            HostsFile.Click += HostsFile_Click;
            // 
            // PowerShellPolicyManager
            // 
            PowerShellPolicyManager.Cursor = Cursors.Hand;
            PowerShellPolicyManager.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PowerShellPolicyManager.Location = new Point(548, 141);
            PowerShellPolicyManager.Margin = new Padding(4, 3, 4, 3);
            PowerShellPolicyManager.Name = "PowerShellPolicyManager";
            PowerShellPolicyManager.Size = new Size(128, 50);
            PowerShellPolicyManager.TabIndex = 40;
            PowerShellPolicyManager.Text = "PowerShell Policy Manager";
            PowerShellPolicyManager.UseVisualStyleBackColor = true;
            PowerShellPolicyManager.Click += PowerShellPolicyManager_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(691, 450);
            Controls.Add(PowerShellPolicyManager);
            Controls.Add(HostsFile);
            Controls.Add(TaskMgrControl);
            Controls.Add(PowerMgr);
            Controls.Add(buildhelp);
            Controls.Add(WindowsSettings);
            Controls.Add(ExplorerPP);
            Controls.Add(AddLocalUser);
            Controls.Add(ProccesHacker);
            Controls.Add(FileExplorer);
            Controls.Add(Taskkiller);
            Controls.Add(TxtWriter);
            Controls.Add(TaskMGR);
            Controls.Add(REGEDIT);
            Controls.Add(CONTROLPANEL);
            Controls.Add(CMD);
            Controls.Add(ZAPRET);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Library";
            ShowIcon = false;
            Text = "Library";
            Load += PcHub_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ZAPRET;
        private Button CMD;
        private Button CONTROLPANEL;
        private Button REGEDIT;
        private Button TaskMGR;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private Button TxtWriter;
        private Button Taskkiller;
        private Button FileExplorer;
        private Button ProccesHacker;
        private Button AddLocalUser;
        private Button ExplorerPP;
        private Button WindowsSettings;
        private Label buildhelp;
        private Button PowerMgr;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button TaskMgrControl;
        private Button HostsFile;
        private Button PowerShellPolicyManager;
    }
}
