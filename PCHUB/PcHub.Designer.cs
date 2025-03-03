namespace PCHUB
{
    partial class PcHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PcHub));
            ZAPRET = new Button();
            pictureBox1 = new PictureBox();
            CMD = new Button();
            EXPLORER = new Button();
            CONTROLPANEL = new Button();
            REGEDIT = new Button();
            RESOURCEMONITOR = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripSeparator();
            build = new Label();
            TxtWriter = new Button();
            Google = new Button();
            Browse = new Button();
            Taskkiller = new Button();
            YouTube = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ZAPRET
            // 
            ZAPRET.Anchor = AnchorStyles.None;
            ZAPRET.Cursor = Cursors.Hand;
            ZAPRET.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZAPRET.Location = new Point(12, 47);
            ZAPRET.Name = "ZAPRET";
            ZAPRET.Size = new Size(128, 50);
            ZAPRET.TabIndex = 0;
            ZAPRET.Text = "ZAPRET";
            ZAPRET.UseVisualStyleBackColor = true;
            ZAPRET.Click += ZAPRET_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.command_prompt_15488;
            pictureBox1.Location = new Point(641, 342);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CMD
            // 
            CMD.Anchor = AnchorStyles.None;
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CMD.Location = new Point(146, 103);
            CMD.Name = "CMD";
            CMD.Size = new Size(128, 50);
            CMD.TabIndex = 2;
            CMD.Text = "CMD";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
            // 
            // EXPLORER
            // 
            EXPLORER.Anchor = AnchorStyles.None;
            EXPLORER.Cursor = Cursors.Hand;
            EXPLORER.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EXPLORER.Location = new Point(12, 103);
            EXPLORER.Name = "EXPLORER";
            EXPLORER.Size = new Size(128, 50);
            EXPLORER.TabIndex = 3;
            EXPLORER.Text = "Explorer";
            EXPLORER.UseVisualStyleBackColor = true;
            EXPLORER.Click += EXPLORER_Click;
            // 
            // CONTROLPANEL
            // 
            CONTROLPANEL.Anchor = AnchorStyles.None;
            CONTROLPANEL.Cursor = Cursors.Hand;
            CONTROLPANEL.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CONTROLPANEL.Location = new Point(280, 106);
            CONTROLPANEL.Name = "CONTROLPANEL";
            CONTROLPANEL.Size = new Size(128, 50);
            CONTROLPANEL.TabIndex = 4;
            CONTROLPANEL.Text = "Control Panel";
            CONTROLPANEL.UseVisualStyleBackColor = true;
            CONTROLPANEL.Click += CONTROLPANEL_Click;
            // 
            // REGEDIT
            // 
            REGEDIT.Anchor = AnchorStyles.None;
            REGEDIT.Cursor = Cursors.Hand;
            REGEDIT.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            REGEDIT.Location = new Point(414, 106);
            REGEDIT.Name = "REGEDIT";
            REGEDIT.Size = new Size(128, 50);
            REGEDIT.TabIndex = 5;
            REGEDIT.Text = "REGEDIT";
            REGEDIT.UseVisualStyleBackColor = true;
            REGEDIT.Click += REGEDIT_Click;
            // 
            // RESOURCEMONITOR
            // 
            RESOURCEMONITOR.Anchor = AnchorStyles.None;
            RESOURCEMONITOR.Cursor = Cursors.Hand;
            RESOURCEMONITOR.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RESOURCEMONITOR.Location = new Point(146, 47);
            RESOURCEMONITOR.Name = "RESOURCEMONITOR";
            RESOURCEMONITOR.Size = new Size(128, 50);
            RESOURCEMONITOR.TabIndex = 6;
            RESOURCEMONITOR.Text = "Task Manager";
            RESOURCEMONITOR.UseVisualStyleBackColor = true;
            RESOURCEMONITOR.Click += RESOURCEMONITOR_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(641, 415);
            label1.Name = "label1";
            label1.Size = new Size(147, 27);
            label1.TabIndex = 7;
            label1.Text = "CUSTOM CMD";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { themeToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
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
            whiteToolStripMenuItem.Size = new Size(180, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(180, 22);
            purpleToolStripMenuItem.Text = "Purple";
            purpleToolStripMenuItem.Click += purpleToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(57, 6);
            // 
            // build
            // 
            build.AutoSize = true;
            build.BackColor = Color.Gray;
            build.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            build.ForeColor = Color.White;
            build.Location = new Point(0, 415);
            build.Name = "build";
            build.Size = new Size(81, 20);
            build.TabIndex = 9;
            build.Text = "BUILD: 1.11";
            // 
            // TxtWriter
            // 
            TxtWriter.Anchor = AnchorStyles.None;
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtWriter.Location = new Point(414, 47);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(128, 50);
            TxtWriter.TabIndex = 10;
            TxtWriter.Text = ".TXT Writer";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // Google
            // 
            Google.Anchor = AnchorStyles.None;
            Google.Cursor = Cursors.Hand;
            Google.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Google.Location = new Point(280, 47);
            Google.Name = "Google";
            Google.Size = new Size(128, 50);
            Google.TabIndex = 12;
            Google.Text = "Google.Com";
            Google.UseVisualStyleBackColor = true;
            Google.Click += Google_Click;
            // 
            // Browse
            // 
            Browse.Anchor = AnchorStyles.None;
            Browse.Cursor = Cursors.Hand;
            Browse.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Browse.Location = new Point(12, 159);
            Browse.Name = "Browse";
            Browse.Size = new Size(128, 50);
            Browse.TabIndex = 13;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // Taskkiller
            // 
            Taskkiller.Cursor = Cursors.Hand;
            Taskkiller.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Taskkiller.Location = new Point(147, 156);
            Taskkiller.Margin = new Padding(4, 3, 4, 3);
            Taskkiller.Name = "Taskkiller";
            Taskkiller.Size = new Size(127, 53);
            Taskkiller.TabIndex = 18;
            Taskkiller.Text = "Taskkiller";
            Taskkiller.UseVisualStyleBackColor = true;
            Taskkiller.Click += Taskkiller_Click;
            // 
            // YouTube
            // 
            YouTube.Anchor = AnchorStyles.None;
            YouTube.Cursor = Cursors.Hand;
            YouTube.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YouTube.Location = new Point(281, 159);
            YouTube.Name = "YouTube";
            YouTube.Size = new Size(128, 50);
            YouTube.TabIndex = 19;
            YouTube.Text = "YouTube";
            YouTube.UseVisualStyleBackColor = true;
            YouTube.Click += YouTube_Click;
            // 
            // PcHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RebeccaPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(YouTube);
            Controls.Add(Taskkiller);
            Controls.Add(Browse);
            Controls.Add(Google);
            Controls.Add(TxtWriter);
            Controls.Add(build);
            Controls.Add(label1);
            Controls.Add(RESOURCEMONITOR);
            Controls.Add(REGEDIT);
            Controls.Add(CONTROLPANEL);
            Controls.Add(EXPLORER);
            Controls.Add(CMD);
            Controls.Add(pictureBox1);
            Controls.Add(ZAPRET);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "PcHub";
            Text = "Library";
            Load += PcHub_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ZAPRET;
        private PictureBox pictureBox1;
        private Button CMD;
        private Button EXPLORER;
        private Button CONTROLPANEL;
        private Button REGEDIT;
        private Button RESOURCEMONITOR;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripComboBox1;
        private Label build;
        private Button TxtWriter;
        private Button Google;
        private Button Browse;
        private Button Taskkiller;
        private Button YouTube;
    }
}
