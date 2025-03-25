namespace PCHUB
{
    partial class AdminApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminApps));
            TxtWriter = new Button();
            RESOURCEMONITOR = new Button();
            REGEDIT = new Button();
            CONTROLPANEL = new Button();
            EXPLORER = new Button();
            CMD = new Button();
            menuStrip1 = new MenuStrip();
            themesToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ExplorerPP = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtWriter
            // 
            TxtWriter.Anchor = AnchorStyles.None;
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtWriter.Location = new Point(14, 44);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(128, 50);
            TxtWriter.TabIndex = 19;
            TxtWriter.Text = ".TXT Writer";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // RESOURCEMONITOR
            // 
            RESOURCEMONITOR.Anchor = AnchorStyles.None;
            RESOURCEMONITOR.Cursor = Cursors.Hand;
            RESOURCEMONITOR.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RESOURCEMONITOR.Location = new Point(148, 44);
            RESOURCEMONITOR.Name = "RESOURCEMONITOR";
            RESOURCEMONITOR.Size = new Size(128, 50);
            RESOURCEMONITOR.TabIndex = 18;
            RESOURCEMONITOR.Text = "Task Manager";
            RESOURCEMONITOR.UseVisualStyleBackColor = true;
            RESOURCEMONITOR.Click += RESOURCEMONITOR_Click;
            // 
            // REGEDIT
            // 
            REGEDIT.Anchor = AnchorStyles.None;
            REGEDIT.Cursor = Cursors.Hand;
            REGEDIT.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            REGEDIT.Location = new Point(550, 45);
            REGEDIT.Name = "REGEDIT";
            REGEDIT.Size = new Size(128, 50);
            REGEDIT.TabIndex = 17;
            REGEDIT.Text = "REGEDIT";
            REGEDIT.UseVisualStyleBackColor = true;
            REGEDIT.Click += REGEDIT_Click;
            // 
            // CONTROLPANEL
            // 
            CONTROLPANEL.Anchor = AnchorStyles.None;
            CONTROLPANEL.Cursor = Cursors.Hand;
            CONTROLPANEL.Font = new Font("Comic Sans MS", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            EXPLORER.Anchor = AnchorStyles.None;
            EXPLORER.Cursor = Cursors.Hand;
            EXPLORER.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EXPLORER.Location = new Point(282, 44);
            EXPLORER.Name = "EXPLORER";
            EXPLORER.Size = new Size(128, 50);
            EXPLORER.TabIndex = 15;
            EXPLORER.Text = "Explorer";
            EXPLORER.UseVisualStyleBackColor = true;
            EXPLORER.Click += EXPLORER_Click;
            // 
            // CMD
            // 
            CMD.Anchor = AnchorStyles.None;
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CMD.Location = new Point(14, 100);
            CMD.Name = "CMD";
            CMD.Size = new Size(128, 50);
            CMD.TabIndex = 14;
            CMD.Text = "CMD";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { themesToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // themesToolStripMenuItem
            // 
            themesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, purpleToolStripMenuItem });
            themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            themesToolStripMenuItem.Size = new Size(61, 20);
            themesToolStripMenuItem.Text = "Themes";
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
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(638, 420);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 27);
            label1.TabIndex = 22;
            label1.Text = "CUSTOM CMD";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.command_prompt_15488;
            pictureBox1.Location = new Point(643, 348);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ExplorerPP
            // 
            ExplorerPP.Anchor = AnchorStyles.None;
            ExplorerPP.Cursor = Cursors.Hand;
            ExplorerPP.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExplorerPP.Location = new Point(148, 100);
            ExplorerPP.Name = "ExplorerPP";
            ExplorerPP.Size = new Size(128, 50);
            ExplorerPP.TabIndex = 23;
            ExplorerPP.Text = "Explorer++";
            ExplorerPP.UseVisualStyleBackColor = true;
            ExplorerPP.Click += ExplorerPP_Click;
            // 
            // AdminApps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExplorerPP);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(TxtWriter);
            Controls.Add(RESOURCEMONITOR);
            Controls.Add(REGEDIT);
            Controls.Add(CONTROLPANEL);
            Controls.Add(EXPLORER);
            Controls.Add(CMD);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "AdminApps";
            Text = "AdminApps";
            Load += AdminApps_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TxtWriter;
        private Button RESOURCEMONITOR;
        private Button REGEDIT;
        private Button CONTROLPANEL;
        private Button EXPLORER;
        private Button CMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private Button ExplorerPP;
    }
}