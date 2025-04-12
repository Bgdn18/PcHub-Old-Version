namespace PCHUB
{
<<<<<<< HEAD
    partial class AdminApps
=======
    partial class otherTools
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
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
<<<<<<< HEAD
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminApps));
            TxtWriter = new Button();
            TaskMgr = new Button();
            REGEDIT = new Button();
            CONTROLPANEL = new Button();
            EXPLORER = new Button();
            CMD = new Button();
========
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otherTools));
            btnCONTROLPANEL = new Button();
            btnCMD = new Button();
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
            menuStrip1 = new MenuStrip();
            themesToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            ExplorerPP = new Button();
            ProccesHacker = new Button();
            IoBitUnlocker = new Button();
            AddLocalUser = new Button();
            TaskMgrControl = new Button();
            BuildLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtWriter
            // 
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Consolas", 9F);
            TxtWriter.Location = new Point(14, 44);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(128, 50);
            TxtWriter.TabIndex = 19;
            TxtWriter.Text = "Writer";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // TaskMgr
            // 
            TaskMgr.Cursor = Cursors.Hand;
            TaskMgr.Font = new Font("Consolas", 9F);
            TaskMgr.Location = new Point(148, 44);
            TaskMgr.Name = "TaskMgr";
            TaskMgr.Size = new Size(128, 50);
            TaskMgr.TabIndex = 18;
            TaskMgr.Text = "Task Mgr";
            TaskMgr.UseVisualStyleBackColor = true;
            TaskMgr.Click += RESOURCEMONITOR_Click;
            // 
            // REGEDIT
            // 
            REGEDIT.Cursor = Cursors.Hand;
            REGEDIT.Font = new Font("Consolas", 9F);
            REGEDIT.Location = new Point(550, 45);
            REGEDIT.Name = "REGEDIT";
            REGEDIT.Size = new Size(128, 50);
            REGEDIT.TabIndex = 17;
            REGEDIT.Text = "REGEDIT";
            REGEDIT.UseVisualStyleBackColor = true;
            REGEDIT.Click += REGEDIT_Click;
========
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otherTools));
            btnCONTROLPANEL = new Button();
            btnCMD = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            btnExplorerPP = new Button();
            btnProccesHacker = new Button();
            btnIoBitUnlocker = new Button();
            BuildLabel = new Label();
            btnZapret = new Button();
            btnRegedit = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCONTROLPANEL
            // 
            btnCONTROLPANEL.Cursor = Cursors.Hand;
            btnCONTROLPANEL.Font = new Font("Consolas", 9F);
            btnCONTROLPANEL.Location = new Point(282, 44);
            btnCONTROLPANEL.Name = "btnCONTROLPANEL";
            btnCONTROLPANEL.Size = new Size(128, 50);
            btnCONTROLPANEL.TabIndex = 16;
            btnCONTROLPANEL.Text = "Control Panel";
            btnCONTROLPANEL.UseVisualStyleBackColor = true;
            btnCONTROLPANEL.Click += CONTROLPANEL_Click;
<<<<<<< HEAD
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
            // 
            // btnCMD
            // 
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            CONTROLPANEL.Cursor = Cursors.Hand;
            CONTROLPANEL.Font = new Font("Consolas", 9F);
            CONTROLPANEL.Location = new Point(416, 45);
            CONTROLPANEL.Name = "CONTROLPANEL";
            CONTROLPANEL.Size = new Size(128, 50);
            CONTROLPANEL.TabIndex = 16;
            CONTROLPANEL.Text = "Control Panel";
            CONTROLPANEL.UseVisualStyleBackColor = true;
            CONTROLPANEL.Click += CONTROLPANEL_Click;
            // 
            // EXPLORER
            // 
            EXPLORER.Cursor = Cursors.Hand;
            EXPLORER.Font = new Font("Consolas", 9F);
            EXPLORER.Location = new Point(282, 44);
            EXPLORER.Name = "EXPLORER";
            EXPLORER.Size = new Size(128, 50);
            EXPLORER.TabIndex = 15;
            EXPLORER.Text = "File Explorer";
            EXPLORER.UseVisualStyleBackColor = true;
            EXPLORER.Click += EXPLORER_Click;
            // 
            // CMD
            // 
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Consolas", 9F);
            CMD.Location = new Point(148, 101);
            CMD.Name = "CMD";
            CMD.Size = new Size(128, 50);
            CMD.TabIndex = 14;
            CMD.Text = "CMD";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
========
=======
            // 
            // btnCMD
            // 
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            btnCMD.Cursor = Cursors.Hand;
            btnCMD.Font = new Font("Consolas", 9F);
            btnCMD.Location = new Point(12, 44);
            btnCMD.Name = "btnCMD";
            btnCMD.Size = new Size(128, 50);
            btnCMD.TabIndex = 14;
            btnCMD.Text = "CMD";
            btnCMD.UseVisualStyleBackColor = true;
            btnCMD.Click += CMD_Click;
<<<<<<< HEAD
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Font = new Font("Consolas", 9F);
<<<<<<< HEAD
            menuStrip1.Items.AddRange(new ToolStripItem[] { themesToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
=======
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(423, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
<<<<<<< HEAD
            // themesToolStripMenuItem
            // 
            themesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, purpleToolStripMenuItem });
            themesToolStripMenuItem.Font = new Font("Consolas", 9F);
            themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            themesToolStripMenuItem.Size = new Size(61, 20);
            themesToolStripMenuItem.Text = "Themes";
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(116, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(116, 22);
            purpleToolStripMenuItem.Text = "Purple";
            purpleToolStripMenuItem.Click += purpleToolStripMenuItem_Click;
            // 
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Font = new Font("Consolas", 9F);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(54, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Font = new Font("Consolas", 9F);
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(47, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // btnExplorerPP
            // 
<<<<<<< HEAD
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            ExplorerPP.Cursor = Cursors.Hand;
            ExplorerPP.Font = new Font("Consolas", 9F);
            ExplorerPP.Location = new Point(282, 100);
            ExplorerPP.Name = "ExplorerPP";
            ExplorerPP.Size = new Size(128, 50);
            ExplorerPP.TabIndex = 23;
            ExplorerPP.Text = "Explorer++";
            ExplorerPP.UseVisualStyleBackColor = true;
            ExplorerPP.Click += ExplorerPP_Click;
========
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            btnExplorerPP.Cursor = Cursors.Hand;
            btnExplorerPP.Font = new Font("Consolas", 9F);
            btnExplorerPP.Location = new Point(148, 44);
            btnExplorerPP.Name = "btnExplorerPP";
            btnExplorerPP.Size = new Size(128, 50);
            btnExplorerPP.TabIndex = 23;
            btnExplorerPP.Text = "Explorer++";
            btnExplorerPP.UseVisualStyleBackColor = true;
            btnExplorerPP.Click += ExplorerPP_Click;
<<<<<<< HEAD
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
            // 
            // btnProccesHacker
            // 
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            ProccesHacker.Cursor = Cursors.Hand;
            ProccesHacker.Font = new Font("Consolas", 9F);
            ProccesHacker.Location = new Point(416, 101);
            ProccesHacker.Name = "ProccesHacker";
            ProccesHacker.Size = new Size(128, 50);
            ProccesHacker.TabIndex = 24;
            ProccesHacker.Text = "Procces Hacker";
            ProccesHacker.UseVisualStyleBackColor = true;
            ProccesHacker.Click += button1_Click;
========
=======
            // 
            // btnProccesHacker
            // 
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            btnProccesHacker.Cursor = Cursors.Hand;
            btnProccesHacker.Font = new Font("Consolas", 9F);
            btnProccesHacker.Location = new Point(12, 100);
            btnProccesHacker.Name = "btnProccesHacker";
            btnProccesHacker.Size = new Size(128, 50);
            btnProccesHacker.TabIndex = 24;
            btnProccesHacker.Text = "Procces Hacker";
            btnProccesHacker.UseVisualStyleBackColor = true;
            btnProccesHacker.Click += processhacker_Click;
<<<<<<< HEAD
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
            // 
            // btnIoBitUnlocker
            // 
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            IoBitUnlocker.Cursor = Cursors.Hand;
            IoBitUnlocker.Font = new Font("Consolas", 9F);
            IoBitUnlocker.Location = new Point(14, 100);
            IoBitUnlocker.Name = "IoBitUnlocker";
            IoBitUnlocker.Size = new Size(128, 50);
            IoBitUnlocker.TabIndex = 25;
            IoBitUnlocker.Text = "Unlocker";
            IoBitUnlocker.UseVisualStyleBackColor = true;
            IoBitUnlocker.Click += IObitUnlocker_Click;
========
=======
            // 
            // btnIoBitUnlocker
            // 
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            btnIoBitUnlocker.Cursor = Cursors.Hand;
            btnIoBitUnlocker.Font = new Font("Consolas", 9F);
            btnIoBitUnlocker.Location = new Point(148, 100);
            btnIoBitUnlocker.Name = "btnIoBitUnlocker";
            btnIoBitUnlocker.Size = new Size(128, 50);
            btnIoBitUnlocker.TabIndex = 25;
            btnIoBitUnlocker.Text = "IObit Unlocker";
            btnIoBitUnlocker.UseVisualStyleBackColor = true;
            btnIoBitUnlocker.Click += IObitUnlocker_Click;
<<<<<<< HEAD
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
            // 
            // AddLocalUser
            // 
            AddLocalUser.Font = new Font("Consolas", 9F);
            AddLocalUser.Location = new Point(550, 100);
            AddLocalUser.Name = "AddLocalUser";
            AddLocalUser.Size = new Size(128, 53);
            AddLocalUser.TabIndex = 26;
            AddLocalUser.Text = "Add Local User 👥";
            AddLocalUser.UseVisualStyleBackColor = true;
            AddLocalUser.Click += LocalUser_Click;
            // 
            // TaskMgrControl
            // 
            TaskMgrControl.Cursor = Cursors.Hand;
            TaskMgrControl.Font = new Font("Consolas", 9F);
            TaskMgrControl.Location = new Point(14, 156);
            TaskMgrControl.Name = "TaskMgrControl";
            TaskMgrControl.Size = new Size(128, 50);
            TaskMgrControl.TabIndex = 27;
            TaskMgrControl.Text = "Task Manager Control";
            TaskMgrControl.UseVisualStyleBackColor = true;
            TaskMgrControl.Click += TaskMgrUnlocker_Click;
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            // 
            // BuildLabel
            // 
            BuildLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
<<<<<<< HEAD
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            BuildLabel.Location = new Point(13, 340);
========
            BuildLabel.Location = new Point(0, 226);
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
=======
            BuildLabel.Location = new Point(0, 226);
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            BuildLabel.Margin = new Padding(4, 0, 4, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 28;
            BuildLabel.Text = "null";
            BuildLabel.Click += BuildLabel_Click;
            // 
<<<<<<< HEAD
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            // AdminApps
========
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            // btnZapret
            // 
            btnZapret.Cursor = Cursors.Hand;
            btnZapret.Font = new Font("Consolas", 9F);
            btnZapret.Location = new Point(282, 100);
            btnZapret.Name = "btnZapret";
            btnZapret.Size = new Size(128, 50);
            btnZapret.TabIndex = 29;
            btnZapret.Text = "Zapret";
            btnZapret.UseVisualStyleBackColor = true;
            btnZapret.Click += btnZapret_Click;
            // 
            // btnRegedit
            // 
            btnRegedit.Cursor = Cursors.Hand;
            btnRegedit.Font = new Font("Consolas", 9F);
            btnRegedit.Location = new Point(12, 156);
            btnRegedit.Name = "btnRegedit";
            btnRegedit.Size = new Size(128, 50);
            btnRegedit.TabIndex = 30;
            btnRegedit.Text = "RegEdit";
            btnRegedit.UseVisualStyleBackColor = true;
            btnRegedit.Click += btnRegedit_Click;
            // 
            // otherTools
<<<<<<< HEAD
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
<<<<<<< HEAD
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            ClientSize = new Size(689, 369);
            Controls.Add(BuildLabel);
            Controls.Add(TaskMgrControl);
            Controls.Add(AddLocalUser);
            Controls.Add(IoBitUnlocker);
            Controls.Add(ProccesHacker);
            Controls.Add(ExplorerPP);
            Controls.Add(TxtWriter);
            Controls.Add(TaskMgr);
            Controls.Add(REGEDIT);
            Controls.Add(CONTROLPANEL);
            Controls.Add(EXPLORER);
            Controls.Add(CMD);
========
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            ClientSize = new Size(423, 256);
            Controls.Add(btnRegedit);
            Controls.Add(btnZapret);
            Controls.Add(BuildLabel);
            Controls.Add(btnIoBitUnlocker);
            Controls.Add(btnProccesHacker);
            Controls.Add(btnExplorerPP);
            Controls.Add(btnCONTROLPANEL);
            Controls.Add(btnCMD);
<<<<<<< HEAD
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(439, 450);
            MinimizeBox = false;
<<<<<<< HEAD
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
            Name = "AdminApps";
========
            MinimumSize = new Size(439, 295);
            Name = "otherTools";
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tools";
=======
            MinimumSize = new Size(439, 295);
            Name = "otherTools";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3rd party Apps";
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
<<<<<<< HEAD
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs

        private Button TxtWriter;
        private Button TaskMgr;
        private Button REGEDIT;
        private Button CONTROLPANEL;
        private Button EXPLORER;
        private Button CMD;
========
        private Button btnCONTROLPANEL;
        private Button btnCMD;
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
        private Button ExplorerPP;
        private Button ProccesHacker;
        private Button IoBitUnlocker;
        private Button AddLocalUser;
========
        private Button btnExplorerPP;
        private Button btnProccesHacker;
        private Button btnIoBitUnlocker;
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button TaskMgrControl;
        private Label BuildLabel;
<<<<<<<< HEAD:PCHUB/AdminApps.Designer.cs
========
        private Button btnZapret;
        private Button btnRegedit;
>>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/OtherTool.Designer.cs
=======
        private Button btnCONTROLPANEL;
        private Button btnCMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnExplorerPP;
        private Button btnProccesHacker;
        private Button btnIoBitUnlocker;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label BuildLabel;
        private Button btnZapret;
        private Button btnRegedit;
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
    }
}