namespace PCHUB
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            PowerManagement = new Button();
            ADMIN = new Button();
            CMD = new Button();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            build = new Label();
            ALL = new Button();
            TxtWriter = new Button();
            WindowsSettings = new Button();
            Taskkiller = new Button();
            ExplorerPP = new Button();
            IOBitUnlocker = new Button();
            LocalUser = new Button();
            fileexplorer = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PowerManagement
            // 
            PowerManagement.Cursor = Cursors.Hand;
            PowerManagement.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PowerManagement.Location = new Point(13, 56);
            PowerManagement.Margin = new Padding(4, 3, 4, 3);
            PowerManagement.Name = "PowerManagement";
            PowerManagement.Size = new Size(178, 53);
            PowerManagement.TabIndex = 0;
            PowerManagement.Text = "Power \r\nmanagement ⚡";
            PowerManagement.UseVisualStyleBackColor = true;
            PowerManagement.Click += PowerManagement_Click;
            // 
            // ADMIN
            // 
            ADMIN.Cursor = Cursors.Hand;
            ADMIN.Font = new Font("Consolas", 9F);
            ADMIN.Location = new Point(284, 233);
            ADMIN.Margin = new Padding(4, 3, 4, 3);
            ADMIN.Name = "ADMIN";
            ADMIN.Size = new Size(178, 53);
            ADMIN.TabIndex = 2;
            ADMIN.Text = "Tools...";
            ADMIN.UseVisualStyleBackColor = true;
            ADMIN.Click += ADMIN_Click;
            // 
            // CMD
            // 
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Consolas", 9F);
            CMD.Location = new Point(13, 292);
            CMD.Margin = new Padding(4, 3, 4, 3);
            CMD.Name = "CMD";
            CMD.Size = new Size(178, 53);
            CMD.TabIndex = 3;
            CMD.Text = "CMD 🖥";
            CMD.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { themeToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(475, 24);
            menuStrip1.TabIndex = 4;
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
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click_1;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(108, 22);
            purpleToolStripMenuItem.Text = "Purple";
            purpleToolStripMenuItem.Click += purpleToolStripMenuItem_Click_1;
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
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // build
            // 
            build.AutoSize = true;
            build.BackColor = Color.Gray;
            build.Cursor = Cursors.Hand;
            build.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            build.ForeColor = Color.White;
            build.Location = new Point(0, 414);
            build.Margin = new Padding(4, 0, 4, 0);
            build.Name = "build";
            build.Size = new Size(126, 20);
            build.TabIndex = 10;
            build.Text = "BUILD: 3/26/2025";
            build.Click += build_Click;
            // 
            // ALL
            // 
            ALL.Cursor = Cursors.Hand;
            ALL.Font = new Font("Consolas", 9F);
            ALL.Location = new Point(284, 292);
            ALL.Margin = new Padding(4, 3, 4, 3);
            ALL.Name = "ALL";
            ALL.Size = new Size(178, 112);
            ALL.TabIndex = 11;
            ALL.Text = "Library...";
            ALL.UseVisualStyleBackColor = true;
            ALL.Click += ALL_Click;
            // 
            // TxtWriter
            // 
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Consolas", 9F);
            TxtWriter.Location = new Point(12, 233);
            TxtWriter.Margin = new Padding(4, 3, 4, 3);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(178, 53);
            TxtWriter.TabIndex = 13;
            TxtWriter.Text = "Writer ✒";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // WindowsSettings
            // 
            WindowsSettings.Cursor = Cursors.Hand;
            WindowsSettings.Font = new Font("Consolas", 9F);
            WindowsSettings.Location = new Point(13, 115);
            WindowsSettings.Margin = new Padding(4, 3, 4, 3);
            WindowsSettings.Name = "WindowsSettings";
            WindowsSettings.Size = new Size(178, 53);
            WindowsSettings.TabIndex = 15;
            WindowsSettings.Text = "Windows Settings ⚙";
            WindowsSettings.UseVisualStyleBackColor = true;
            // 
            // Taskkiller
            // 
            Taskkiller.Cursor = Cursors.Hand;
            Taskkiller.Font = new Font("Consolas", 9F);
            Taskkiller.Location = new Point(12, 174);
            Taskkiller.Margin = new Padding(4, 3, 4, 3);
            Taskkiller.Name = "Taskkiller";
            Taskkiller.Size = new Size(178, 53);
            Taskkiller.TabIndex = 17;
            Taskkiller.Text = "TaskKill";
            Taskkiller.UseVisualStyleBackColor = true;
            Taskkiller.Click += Taskkiller_Click;
            // 
            // ExplorerPP
            // 
            ExplorerPP.Font = new Font("Consolas", 9F);
            ExplorerPP.Location = new Point(13, 351);
            ExplorerPP.Name = "ExplorerPP";
            ExplorerPP.Size = new Size(178, 53);
            ExplorerPP.TabIndex = 19;
            ExplorerPP.Text = "Explorer++";
            ExplorerPP.UseVisualStyleBackColor = true;
            // 
            // IOBitUnlocker
            // 
            IOBitUnlocker.Cursor = Cursors.Hand;
            IOBitUnlocker.Font = new Font("Consolas", 9F);
            IOBitUnlocker.Location = new Point(284, 56);
            IOBitUnlocker.Margin = new Padding(4, 3, 4, 3);
            IOBitUnlocker.Name = "IOBitUnlocker";
            IOBitUnlocker.Size = new Size(178, 53);
            IOBitUnlocker.TabIndex = 20;
            IOBitUnlocker.Text = "Unlocker";
            IOBitUnlocker.UseVisualStyleBackColor = true;
            IOBitUnlocker.Click += IOBitUnlocker_Click;
            // 
            // LocalUser
            // 
            LocalUser.Font = new Font("Consolas", 9F);
            LocalUser.Location = new Point(284, 174);
            LocalUser.Name = "LocalUser";
            LocalUser.Size = new Size(178, 53);
            LocalUser.TabIndex = 21;
            LocalUser.Text = "Add Local User 👥";
            LocalUser.UseVisualStyleBackColor = true;
            LocalUser.Click += button1_Click;
            // 
            // fileexplorer
            // 
            fileexplorer.Font = new Font("Consolas", 9F);
            fileexplorer.Location = new Point(284, 115);
            fileexplorer.Name = "fileexplorer";
            fileexplorer.Size = new Size(178, 53);
            fileexplorer.TabIndex = 22;
            fileexplorer.Text = "File Explorer 🚎";
            fileexplorer.UseVisualStyleBackColor = true;
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(475, 444);
            Controls.Add(fileexplorer);
            Controls.Add(LocalUser);
            Controls.Add(IOBitUnlocker);
            Controls.Add(ExplorerPP);
            Controls.Add(Taskkiller);
            Controls.Add(WindowsSettings);
            Controls.Add(TxtWriter);
            Controls.Add(ALL);
            Controls.Add(build);
            Controls.Add(CMD);
            Controls.Add(ADMIN);
            Controls.Add(PowerManagement);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MAIN";
            Text = "PcHub for Windows 10/11";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PowerManagement;
        private Button ADMIN;
        private Button CMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label build;
        private Button ALL;
        private Button TxtWriter;
        private Button WindowsSettings;
        private Button Taskkiller;
        private Button ExplorerPP;
        private Button IOBitUnlocker;
        private Button LocalUser;
        private Button fileexplorer;
    }
}