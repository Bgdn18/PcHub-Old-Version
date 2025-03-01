namespace PCHUB
{
    partial class PowerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerManagement));
            Shutdown = new Button();
            Restart = new Button();
            menuStrip1 = new MenuStrip();
            toHubToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Shutdown
            // 
            Shutdown.Cursor = Cursors.Hand;
            Shutdown.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shutdown.Location = new Point(12, 27);
            Shutdown.Name = "Shutdown";
            Shutdown.Size = new Size(193, 58);
            Shutdown.TabIndex = 0;
            Shutdown.Text = "Shutdown";
            Shutdown.UseVisualStyleBackColor = true;
            Shutdown.Click += Shutdown_Click;
            // 
            // Restart
            // 
            Restart.Cursor = Cursors.Hand;
            Restart.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Restart.Location = new Point(216, 27);
            Restart.Name = "Restart";
            Restart.Size = new Size(193, 58);
            Restart.TabIndex = 1;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toHubToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(436, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toHubToolStripMenuItem
            // 
            toHubToolStripMenuItem.Name = "toHubToolStripMenuItem";
            toHubToolStripMenuItem.Size = new Size(58, 20);
            toHubToolStripMenuItem.Text = "To Hub";
            toHubToolStripMenuItem.Click += toHubToolStripMenuItem_Click;
            // 
            // PowerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 111);
            Controls.Add(Restart);
            Controls.Add(Shutdown);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "PowerManagement";
            Text = "PowerManagement";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Shutdown;
        private Button Restart;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toHubToolStripMenuItem;
    }
}