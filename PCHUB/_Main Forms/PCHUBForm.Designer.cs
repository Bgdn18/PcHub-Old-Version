﻿namespace PCHUB
{
    partial class PCHUBForm
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
<<<<<<< HEAD:PCHUB/Library.Designer.cs
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            btnZAPRET = new Button();
            btnCMD = new Button();
            btnCONTROLPANEL = new Button();
            btnREGEDIT = new Button();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCHUBForm));
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
            btnTaskMGR = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            btnTxtWriter = new Button();
            btnTaskkiller = new Button();
            btnFileExplorer = new Button();
            btnAddLocalUser = new Button();
            BuildLabel = new Label();
            btnPowerMgr = new Button();
            btnHostsFile = new Button();
            btnPowerShellPolicyManager = new Button();
<<<<<<< HEAD:PCHUB/Library.Designer.cs
            label1 = new Label();
            btnIObitUnlocker = new Button();
            label2 = new Label();
=======
            HybsLabel = new Label();
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
            btnTools = new Button();
            btnFileDelete = new Button();
            btnUninstaller = new Button();
            btnBrowseForms = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
<<<<<<< HEAD:PCHUB/Library.Designer.cs
            // btnZAPRET
            // 
            btnZAPRET.Cursor = Cursors.Hand;
            btnZAPRET.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZAPRET.Location = new Point(143, 172);
            btnZAPRET.Name = "btnZAPRET";
            btnZAPRET.Size = new Size(124, 35);
            btnZAPRET.TabIndex = 0;
            btnZAPRET.Text = "ZAPRET 🐱‍👤";
            btnZAPRET.UseVisualStyleBackColor = true;
            btnZAPRET.Click += ZAPRET_Click;
            // 
            // btnCMD
            // 
            btnCMD.Cursor = Cursors.Hand;
            btnCMD.Font = new Font("Consolas", 8.25F);
            btnCMD.Location = new Point(537, 90);
            btnCMD.Name = "btnCMD";
            btnCMD.Size = new Size(125, 35);
            btnCMD.TabIndex = 2;
            btnCMD.Text = "CMD ";
            btnCMD.UseVisualStyleBackColor = true;
            btnCMD.Click += CMD_Click;
            // 
            // btnCONTROLPANEL
            // 
            btnCONTROLPANEL.Cursor = Cursors.Hand;
            btnCONTROLPANEL.Font = new Font("Consolas", 8.25F);
            btnCONTROLPANEL.Location = new Point(405, 90);
            btnCONTROLPANEL.Name = "btnCONTROLPANEL";
            btnCONTROLPANEL.Size = new Size(125, 35);
            btnCONTROLPANEL.TabIndex = 4;
            btnCONTROLPANEL.Text = "Control Panel 🛂";
            btnCONTROLPANEL.UseVisualStyleBackColor = true;
            btnCONTROLPANEL.Click += CONTROLPANEL_Click;
            // 
            // btnREGEDIT
            // 
            btnREGEDIT.Cursor = Cursors.Hand;
            btnREGEDIT.Font = new Font("Consolas", 8.25F);
            btnREGEDIT.Location = new Point(274, 90);
            btnREGEDIT.Name = "btnREGEDIT";
            btnREGEDIT.Size = new Size(125, 35);
            btnREGEDIT.TabIndex = 5;
            btnREGEDIT.Text = "REGEDIT ®";
            btnREGEDIT.UseVisualStyleBackColor = true;
            btnREGEDIT.Click += REGEDIT_Click;
            // 
=======
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
            // btnTaskMGR
            // 
            btnTaskMGR.Anchor = AnchorStyles.Top;
            btnTaskMGR.Cursor = Cursors.Hand;
            btnTaskMGR.Font = new Font("Consolas", 8.25F);
            btnTaskMGR.Location = new Point(368, 118);
            btnTaskMGR.Name = "btnTaskMGR";
            btnTaskMGR.Size = new Size(125, 35);
            btnTaskMGR.TabIndex = 6;
            btnTaskMGR.Text = "Task Manager";
            btnTaskMGR.UseVisualStyleBackColor = true;
            btnTaskMGR.Click += TaskManager_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem, runToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(864, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
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
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(40, 20);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // btnTxtWriter
            // 
            btnTxtWriter.Anchor = AnchorStyles.Top;
            btnTxtWriter.Cursor = Cursors.Hand;
            btnTxtWriter.Font = new Font("Consolas", 8.25F);
            btnTxtWriter.Location = new Point(235, 118);
            btnTxtWriter.Name = "btnTxtWriter";
            btnTxtWriter.Size = new Size(125, 35);
            btnTxtWriter.TabIndex = 10;
            btnTxtWriter.Text = "Writer";
            btnTxtWriter.UseVisualStyleBackColor = true;
            btnTxtWriter.Click += TxtWriter_Click;
            // 
            // btnTaskkiller
            // 
            btnTaskkiller.Anchor = AnchorStyles.Top;
            btnTaskkiller.Cursor = Cursors.Hand;
            btnTaskkiller.Font = new Font("Consolas", 8.25F);
            btnTaskkiller.Location = new Point(368, 77);
            btnTaskkiller.Margin = new Padding(4, 3, 4, 3);
            btnTaskkiller.Name = "btnTaskkiller";
            btnTaskkiller.Size = new Size(125, 35);
            btnTaskkiller.TabIndex = 18;
            btnTaskkiller.Text = "TaskKiller";
            btnTaskkiller.UseVisualStyleBackColor = true;
            btnTaskkiller.Click += Taskkiller_Click;
            // 
            // btnFileExplorer
            // 
            btnFileExplorer.Anchor = AnchorStyles.Top;
            btnFileExplorer.Cursor = Cursors.Hand;
            btnFileExplorer.Font = new Font("Consolas", 8.25F);
            btnFileExplorer.Location = new Point(500, 118);
            btnFileExplorer.Name = "btnFileExplorer";
            btnFileExplorer.Size = new Size(125, 35);
            btnFileExplorer.TabIndex = 23;
            btnFileExplorer.Text = "File Explorer";
            btnFileExplorer.UseVisualStyleBackColor = true;
            btnFileExplorer.Click += FileExplorer_Click;
            // 
            // btnAddLocalUser
            // 
            btnAddLocalUser.Anchor = AnchorStyles.Top;
            btnAddLocalUser.Cursor = Cursors.Hand;
            btnAddLocalUser.Font = new Font("Consolas", 8.25F);
            btnAddLocalUser.Location = new Point(235, 36);
            btnAddLocalUser.Name = "btnAddLocalUser";
            btnAddLocalUser.Size = new Size(125, 35);
            btnAddLocalUser.TabIndex = 32;
            btnAddLocalUser.Text = "Add Local User";
            btnAddLocalUser.UseVisualStyleBackColor = true;
            btnAddLocalUser.Click += btnLocalUser_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(0, 527);
            BuildLabel.Margin = new Padding(4, 0, 4, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 36;
            BuildLabel.Text = "null";
            BuildLabel.Click += btnbuildhelp_Click;
            // 
            // btnPowerMgr
            // 
            btnPowerMgr.Anchor = AnchorStyles.Top;
            btnPowerMgr.Cursor = Cursors.Hand;
            btnPowerMgr.Font = new Font("Consolas", 8.25F);
            btnPowerMgr.Location = new Point(235, 77);
            btnPowerMgr.Margin = new Padding(4, 3, 4, 3);
            btnPowerMgr.Name = "btnPowerMgr";
            btnPowerMgr.Size = new Size(125, 35);
            btnPowerMgr.TabIndex = 37;
            btnPowerMgr.Text = "Power \r\nmanagement";
            btnPowerMgr.UseVisualStyleBackColor = true;
            btnPowerMgr.Click += btnPowerMgr_Click;
            // 
            // btnHostsFile
            // 
            btnHostsFile.Anchor = AnchorStyles.Top;
            btnHostsFile.Cursor = Cursors.Hand;
            btnHostsFile.Font = new Font("Consolas", 8.25F);
            btnHostsFile.Location = new Point(500, 36);
            btnHostsFile.Margin = new Padding(4, 3, 4, 3);
            btnHostsFile.Name = "btnHostsFile";
            btnHostsFile.Size = new Size(125, 35);
            btnHostsFile.TabIndex = 39;
            btnHostsFile.Text = "HostsFile";
            btnHostsFile.UseVisualStyleBackColor = true;
            btnHostsFile.Click += btnHostsFile_Click;
            // 
            // btnPowerShellPolicyManager
            // 
            btnPowerShellPolicyManager.Anchor = AnchorStyles.Top;
            btnPowerShellPolicyManager.Cursor = Cursors.Hand;
            btnPowerShellPolicyManager.Font = new Font("Consolas", 8.25F);
            btnPowerShellPolicyManager.Location = new Point(500, 77);
            btnPowerShellPolicyManager.Margin = new Padding(4, 3, 4, 3);
            btnPowerShellPolicyManager.Name = "btnPowerShellPolicyManager";
            btnPowerShellPolicyManager.Size = new Size(125, 35);
            btnPowerShellPolicyManager.TabIndex = 40;
            btnPowerShellPolicyManager.Text = "PowerShell Policy Manager";
            btnPowerShellPolicyManager.UseVisualStyleBackColor = true;
            btnPowerShellPolicyManager.Click += btnPowerShellPolicyManager_Click;
            // 
            // HybsLabel
            // 
<<<<<<< HEAD:PCHUB/Library.Designer.cs
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 41;
            label1.Text = "Library:";
            // 
            // btnIObitUnlocker
            // 
            btnIObitUnlocker.Cursor = Cursors.Hand;
            btnIObitUnlocker.Font = new Font("Consolas", 8.25F);
            btnIObitUnlocker.Location = new Point(12, 172);
            btnIObitUnlocker.Margin = new Padding(4, 3, 4, 3);
            btnIObitUnlocker.Name = "btnIObitUnlocker";
            btnIObitUnlocker.Size = new Size(125, 35);
            btnIObitUnlocker.TabIndex = 42;
            btnIObitUnlocker.Text = "IObit Unlocker 🗝";
            btnIObitUnlocker.UseVisualStyleBackColor = true;
            btnIObitUnlocker.Click += btnIObitUnlocker_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 43;
            label2.Text = "Hubs:";
=======
            HybsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            HybsLabel.AutoSize = true;
            HybsLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HybsLabel.Location = new Point(12, 454);
            HybsLabel.Name = "HybsLabel";
            HybsLabel.Size = new Size(60, 22);
            HybsLabel.TabIndex = 43;
            HybsLabel.Text = "Hubs:";
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
            // 
            // btnTools
            // 
            btnTools.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTools.Cursor = Cursors.Hand;
            btnTools.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTools.Location = new Point(12, 479);
            btnTools.Margin = new Padding(4, 3, 4, 3);
            btnTools.Name = "btnTools";
            btnTools.Size = new Size(124, 35);
            btnTools.TabIndex = 44;
            btnTools.Text = "3rd Party Apps";
            btnTools.UseVisualStyleBackColor = true;
            btnTools.Click += btnTools_Click;
            // 
            // btnFileDelete
            // 
            btnFileDelete.Anchor = AnchorStyles.Top;
            btnFileDelete.Cursor = Cursors.Hand;
            btnFileDelete.Font = new Font("Consolas", 8.25F);
            btnFileDelete.Location = new Point(367, 36);
            btnFileDelete.Margin = new Padding(4, 3, 4, 3);
            btnFileDelete.Name = "btnFileDelete";
            btnFileDelete.Size = new Size(126, 35);
            btnFileDelete.TabIndex = 46;
            btnFileDelete.Text = "File Delete";
            btnFileDelete.UseVisualStyleBackColor = true;
            btnFileDelete.Click += btnFileDelete_Click;
            // 
            // btnUninstaller
            // 
            btnUninstaller.Anchor = AnchorStyles.Top;
            btnUninstaller.Cursor = Cursors.Hand;
            btnUninstaller.Font = new Font("Consolas", 8.25F);
            btnUninstaller.Location = new Point(235, 159);
            btnUninstaller.Name = "btnUninstaller";
            btnUninstaller.Size = new Size(125, 35);
            btnUninstaller.TabIndex = 47;
            btnUninstaller.Text = "UnInstaller";
            btnUninstaller.UseVisualStyleBackColor = true;
            btnUninstaller.Click += btnUninstaller_Click;
            // 
            // btnBrowseForms
            // 
            btnBrowseForms.Anchor = AnchorStyles.Top;
            btnBrowseForms.Cursor = Cursors.Hand;
            btnBrowseForms.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowseForms.Location = new Point(367, 159);
            btnBrowseForms.Margin = new Padding(4, 3, 4, 3);
            btnBrowseForms.Name = "btnBrowseForms";
            btnBrowseForms.Size = new Size(126, 35);
            btnBrowseForms.TabIndex = 48;
            btnBrowseForms.Text = "Browse Forms";
            btnBrowseForms.UseVisualStyleBackColor = true;
            btnBrowseForms.Click += btnBrowseForms_Click;
            // 
            // PCHUBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(864, 556);
            Controls.Add(btnBrowseForms);
            Controls.Add(btnUninstaller);
            Controls.Add(btnFileDelete);
            Controls.Add(btnTools);
<<<<<<< HEAD:PCHUB/Library.Designer.cs
            Controls.Add(label2);
            Controls.Add(btnIObitUnlocker);
            Controls.Add(label1);
=======
            Controls.Add(HybsLabel);
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
            Controls.Add(btnPowerShellPolicyManager);
            Controls.Add(btnHostsFile);
            Controls.Add(btnPowerMgr);
            Controls.Add(BuildLabel);
            Controls.Add(btnAddLocalUser);
            Controls.Add(btnFileExplorer);
            Controls.Add(btnTaskkiller);
            Controls.Add(btnTxtWriter);
            Controls.Add(btnTaskMGR);
<<<<<<< HEAD:PCHUB/Library.Designer.cs
            Controls.Add(btnREGEDIT);
            Controls.Add(btnCONTROLPANEL);
            Controls.Add(btnCMD);
            Controls.Add(btnZAPRET);
=======
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 900);
            MinimizeBox = false;
<<<<<<< HEAD:PCHUB/Library.Designer.cs
            Name = "Library";
            ShowIcon = false;
=======
            MinimumSize = new Size(500, 500);
            Name = "PCHUBForm";
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PcHub";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
<<<<<<< HEAD:PCHUB/Library.Designer.cs

        private Button btnZAPRET;
        private Button btnCMD;
        private Button btnCONTROLPANEL;
        private Button btnREGEDIT;
=======
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
        private Button btnTaskMGR;
        private MenuStrip menuStrip1;
        private Button btnTxtWriter;
        private Button btnTaskkiller;
        private Button btnFileExplorer;
        private Button btnAddLocalUser;
        private Label BuildLabel;
        private Button btnPowerMgr;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnHostsFile;
        private Button btnPowerShellPolicyManager;
<<<<<<< HEAD:PCHUB/Library.Designer.cs
        private Label label1;
        private Button btnIObitUnlocker;
        private ToolStripMenuItem aDDTOSTARTUPToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label2;
=======
        private Label HybsLabel;
>>>>>>> NewFeatureBranch:PCHUB/_Main Forms/PCHUBForm.Designer.cs
        private Button btnTools;
        private Button btnFileDelete;
        private Button btnUninstaller;
        private ToolStripMenuItem runToolStripMenuItem;
        private Button btnBrowseForms;
    }
}
