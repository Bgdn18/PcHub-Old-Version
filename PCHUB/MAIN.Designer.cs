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
            Programs = new Button();
            ADMIN = new Button();
            CMD = new Button();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            build = new Label();
            ALL = new Button();
            label2 = new Label();
            TxtWriter = new Button();
            label3 = new Label();
            Settings = new Button();
            button1 = new Button();
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
            PowerManagement.Text = "Power management";
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
            ADMIN.Text = "ADMIN";
            ADMIN.UseVisualStyleBackColor = true;
            ADMIN.Click += ADMIN_Click;
            // 
            // CMD
            // 
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CMD.Location = new Point(552, 38);
            CMD.Margin = new Padding(4, 3, 4, 3);
            CMD.Name = "CMD";
            CMD.Size = new Size(174, 53);
            CMD.TabIndex = 3;
            CMD.Text = "CMD";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
            // 
            // menuStrip1
            // 
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
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(663, 419);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 9;
            label1.Text = "CUSTOM CMD";
            label1.Click += label1_Click;
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
            build.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            build.ForeColor = Color.White;
            build.Location = new Point(0, 414);
            build.Margin = new Padding(4, 0, 4, 0);
            build.Name = "build";
            build.Size = new Size(75, 20);
            build.TabIndex = 10;
            build.Text = "BUILD: 1.1";
            // 
            // ALL
            // 
            ALL.Cursor = Cursors.Hand;
            ALL.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ALL.Location = new Point(482, 342);
            ALL.Margin = new Padding(4, 3, 4, 3);
            ALL.Name = "ALL";
            ALL.Size = new Size(158, 70);
            ALL.TabIndex = 11;
            ALL.Text = "AllPcHubLibrary";
            ALL.UseVisualStyleBackColor = true;
            ALL.Click += ALL_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(522, 415);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 12;
            label2.Text = "Library";
            // 
            // TxtWriter
            // 
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtWriter.Location = new Point(318, 342);
            TxtWriter.Margin = new Padding(4, 3, 4, 3);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(158, 70);
            TxtWriter.TabIndex = 13;
            TxtWriter.Text = "Txt Writer";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(333, 418);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 14;
            label3.Text = "ADD TXT FILE";
            // 
            // Settings
            // 
            Settings.Cursor = Cursors.Hand;
            Settings.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settings.Location = new Point(12, 97);
            Settings.Margin = new Padding(4, 3, 4, 3);
            Settings.Name = "Settings";
            Settings.Size = new Size(174, 53);
            Settings.TabIndex = 15;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(132, 345);
            button1.Name = "button1";
            button1.Size = new Size(179, 66);
            button1.TabIndex = 16;
            button1.Text = "Browse in your \r\ndefoult browser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Settings);
            Controls.Add(label3);
            Controls.Add(TxtWriter);
            Controls.Add(label2);
            Controls.Add(ALL);
            Controls.Add(build);
            Controls.Add(label1);
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
        private Label label1;
        private PictureBox pictureBox1;
        private Label build;
        private Button ALL;
        private Label label2;
        private Button TxtWriter;
        private Label label3;
        private Button Settings;
        private Button button1;
    }
}