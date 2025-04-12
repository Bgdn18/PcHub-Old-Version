﻿namespace PCHUB
{
    partial class Delete_files
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_files));
            txtPath = new TextBox();
            btnDelete = new Button();
            btnBrowseFile = new Button();
            btnBrowseFolder = new Button();
            menuStrip1 = new MenuStrip();
            fileExplorerToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPath.Location = new Point(12, 37);
            txtPath.Multiline = true;
            txtPath.Name = "txtPath";
            txtPath.PlaceholderText = "Path to File/Folder";
            txtPath.Size = new Size(316, 31);
            txtPath.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Consolas", 9F);
            btnDelete.Location = new Point(13, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(315, 31);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Cursor = Cursors.Hand;
            btnBrowseFile.Font = new Font("Consolas", 8.25F);
            btnBrowseFile.Location = new Point(334, 37);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(97, 31);
            btnBrowseFile.TabIndex = 3;
            btnBrowseFile.Text = "View File";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Cursor = Cursors.Hand;
            btnBrowseFolder.Font = new Font("Consolas", 8.25F);
            btnBrowseFolder.Location = new Point(334, 75);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new Size(97, 31);
            btnBrowseFolder.TabIndex = 4;
            btnBrowseFolder.Text = "View Folder";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileExplorerToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(443, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileExplorerToolStripMenuItem
            // 
            fileExplorerToolStripMenuItem.Font = new Font("Consolas", 9F);
            fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
            fileExplorerToolStripMenuItem.Size = new Size(110, 20);
            fileExplorerToolStripMenuItem.Text = "File Explorer";
            fileExplorerToolStripMenuItem.Click += fileExplorerToolStripMenuItem_Click;
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
            // Delete_files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 117);
            Controls.Add(btnBrowseFolder);
            Controls.Add(btnBrowseFile);
            Controls.Add(btnDelete);
            Controls.Add(txtPath);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Delete_files";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Force File Deleter";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDelete;
        private Button btnBrowseFile;
        private Button btnBrowseFolder;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem fileExplorerToolStripMenuItem;
    }
}