﻿namespace PCHUB
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
            Programs = new Button();
            ADMIN = new Button();
            CMD = new Button();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            CUSTOMCMD_TEXT = new Label();
            pictureBox1 = new PictureBox();
            build = new Label();
            ALL = new Button();
            TxtWriter = new Button();
            ADDTXTFILE_TEXT = new Label();
            Settings = new Button();
            button1 = new Button();
            Taskkiller = new Button();
            YOUTUBE = new Button();
            ExplorerPP = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PowerManagement
            // 
            PowerManagement.Cursor = Cursors.Hand;
            PowerManagement.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PowerManagement.Location = new Point(12, 38);
            PowerManagement.Margin = new Padding(4, 3, 4, 3);
            PowerManagement.Name = "PowerManagement";
            PowerManagement.Size = new Size(174, 53);
            PowerManagement.TabIndex = 0;
            PowerManagement.Text = "Power \r\nmanagement";
            PowerManagement.UseVisualStyleBackColor = true;
            PowerManagement.Click += PowerManagement_Click;
            // 
            // Programs
            // 
            Programs.Cursor = Cursors.Hand;
            Programs.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Programs.Location = new Point(192, 37);
            Programs.Margin = new Padding(4, 3, 4, 3);
            Programs.Name = "Programs";
            Programs.Size = new Size(174, 53);
            Programs.TabIndex = 1;
            Programs.Text = "Programs";
            Programs.UseVisualStyleBackColor = true;
            Programs.Click += Programs_Click;
            // 
            // ADMIN
            // 
            ADMIN.Cursor = Cursors.Hand;
            ADMIN.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADMIN.Location = new Point(372, 38);
            ADMIN.Margin = new Padding(4, 3, 4, 3);
            ADMIN.Name = "ADMIN";
            ADMIN.Size = new Size(174, 53);
            ADMIN.TabIndex = 2;
            ADMIN.Text = "System";
            ADMIN.UseVisualStyleBackColor = true;
            ADMIN.Click += ADMIN_Click;
            // 
            // CMD
            // 
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CMD.Location = new Point(384, 342);
            CMD.Margin = new Padding(4, 3, 4, 3);
            CMD.Name = "CMD";
            CMD.Size = new Size(87, 70);
            CMD.TabIndex = 3;
            CMD.Text = "CMD";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { themeToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, purpleToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(56, 20);
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
            // CUSTOMCMD_TEXT
            // 
            CUSTOMCMD_TEXT.Anchor = AnchorStyles.None;
            CUSTOMCMD_TEXT.AutoSize = true;
            CUSTOMCMD_TEXT.BorderStyle = BorderStyle.Fixed3D;
            CUSTOMCMD_TEXT.Cursor = Cursors.Hand;
            CUSTOMCMD_TEXT.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CUSTOMCMD_TEXT.ForeColor = Color.Black;
            CUSTOMCMD_TEXT.Location = new Point(661, 419);
            CUSTOMCMD_TEXT.Margin = new Padding(4, 0, 4, 0);
            CUSTOMCMD_TEXT.Name = "CUSTOMCMD_TEXT";
            CUSTOMCMD_TEXT.Size = new Size(126, 25);
            CUSTOMCMD_TEXT.TabIndex = 9;
            CUSTOMCMD_TEXT.Text = "CUSTOM CMD";
            CUSTOMCMD_TEXT.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.command_prompt_15488;
            pictureBox1.Location = new Point(645, 342);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            build.Size = new Size(117, 20);
            build.TabIndex = 10;
            build.Text = "BUILD: 3/5/2025";
            build.Click += build_Click;
            // 
            // ALL
            // 
            ALL.Cursor = Cursors.Hand;
            ALL.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ALL.Location = new Point(372, 97);
            ALL.Margin = new Padding(4, 3, 4, 3);
            ALL.Name = "ALL";
            ALL.Size = new Size(174, 53);
            ALL.TabIndex = 11;
            ALL.Text = "Library";
            ALL.UseVisualStyleBackColor = true;
            ALL.Click += ALL_Click;
            // 
            // TxtWriter
            // 
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtWriter.Location = new Point(479, 342);
            TxtWriter.Margin = new Padding(4, 3, 4, 3);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(158, 70);
            TxtWriter.TabIndex = 13;
            TxtWriter.Text = ".Txt Writer";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // ADDTXTFILE_TEXT
            // 
            ADDTXTFILE_TEXT.Anchor = AnchorStyles.None;
            ADDTXTFILE_TEXT.AutoSize = true;
            ADDTXTFILE_TEXT.BorderStyle = BorderStyle.Fixed3D;
            ADDTXTFILE_TEXT.Cursor = Cursors.Hand;
            ADDTXTFILE_TEXT.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ADDTXTFILE_TEXT.ForeColor = Color.Black;
            ADDTXTFILE_TEXT.Location = new Point(496, 419);
            ADDTXTFILE_TEXT.Margin = new Padding(4, 0, 4, 0);
            ADDTXTFILE_TEXT.Name = "ADDTXTFILE_TEXT";
            ADDTXTFILE_TEXT.Size = new Size(134, 25);
            ADDTXTFILE_TEXT.TabIndex = 14;
            ADDTXTFILE_TEXT.Text = "ADD TXT FILE";
            ADDTXTFILE_TEXT.Click += ADDTXTFILE_TEXT_Click;
            // 
            // Settings
            // 
            Settings.Cursor = Cursors.Hand;
            Settings.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settings.Location = new Point(554, 39);
            Settings.Margin = new Padding(4, 3, 4, 3);
            Settings.Name = "Settings";
            Settings.Size = new Size(174, 53);
            Settings.TabIndex = 15;
            Settings.Text = "Settings Microsoft";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(174, 53);
            button1.TabIndex = 16;
            button1.Text = "Browse in your \r\ndefoult browser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Taskkiller
            // 
            Taskkiller.Cursor = Cursors.Hand;
            Taskkiller.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Taskkiller.Location = new Point(192, 97);
            Taskkiller.Margin = new Padding(4, 3, 4, 3);
            Taskkiller.Name = "Taskkiller";
            Taskkiller.Size = new Size(174, 53);
            Taskkiller.TabIndex = 17;
            Taskkiller.Text = "Taskkiller";
            Taskkiller.UseVisualStyleBackColor = true;
            Taskkiller.Click += Taskkiller_Click;
            // 
            // YOUTUBE
            // 
            YOUTUBE.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YOUTUBE.Location = new Point(12, 156);
            YOUTUBE.Name = "YOUTUBE";
            YOUTUBE.Size = new Size(174, 53);
            YOUTUBE.TabIndex = 18;
            YOUTUBE.Text = "YouTube ";
            YOUTUBE.UseVisualStyleBackColor = true;
            YOUTUBE.Click += YOUTUBE_Click;
            // 
            // ExplorerPP
            // 
            ExplorerPP.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExplorerPP.Location = new Point(192, 156);
            ExplorerPP.Name = "ExplorerPP";
            ExplorerPP.Size = new Size(174, 53);
            ExplorerPP.TabIndex = 19;
            ExplorerPP.Text = "Explorer++";
            ExplorerPP.UseVisualStyleBackColor = true;
            ExplorerPP.Click += ExplorerPP_Click;
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ExplorerPP);
            Controls.Add(YOUTUBE);
            Controls.Add(Taskkiller);
            Controls.Add(button1);
            Controls.Add(Settings);
            Controls.Add(ADDTXTFILE_TEXT);
            Controls.Add(TxtWriter);
            Controls.Add(ALL);
            Controls.Add(build);
            Controls.Add(CUSTOMCMD_TEXT);
            Controls.Add(pictureBox1);
            Controls.Add(CMD);
            Controls.Add(ADMIN);
            Controls.Add(Programs);
            Controls.Add(PowerManagement);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MAIN";
            Text = "PcHub for Windows 10/11";
            Load += MAIN_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PowerManagement;
        private Button Programs;
        private Button ADMIN;
        private Button CMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label CUSTOMCMD_TEXT;
        private PictureBox pictureBox1;
        private Label build;
        private Button ALL;
        private Button TxtWriter;
        private Label ADDTXTFILE_TEXT;
        private Button Settings;
        private Button button1;
        private Button Taskkiller;
        private Button YOUTUBE;
        private Button ExplorerPP;
    }
}