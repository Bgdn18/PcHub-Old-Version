namespace PCHUB
{
    partial class TaskKiller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskKiller));
            btnKillProcess = new Button();
            txtProcessName = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKillProcess
            // 
            btnKillProcess.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKillProcess.Location = new Point(12, 174);
            btnKillProcess.Name = "btnKillProcess";
            btnKillProcess.Size = new Size(118, 59);
            btnKillProcess.TabIndex = 0;
            btnKillProcess.Text = "KILL";
            btnKillProcess.UseVisualStyleBackColor = true;
            btnKillProcess.Click += btnKillProcess_Click;
            // 
            // txtProcessName
            // 
            txtProcessName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProcessName.Location = new Point(12, 37);
            txtProcessName.Multiline = true;
            txtProcessName.Name = "txtProcessName";
            txtProcessName.PlaceholderText = "PCHUB";
            txtProcessName.Size = new Size(776, 131);
            txtProcessName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(622, 236);
            label1.Name = "label1";
            label1.Size = new Size(166, 34);
            label1.TabIndex = 2;
            label1.Text = "TASKKILLER";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { themeToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
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
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(108, 22);
            purpleToolStripMenuItem.Text = "Purple";
            purpleToolStripMenuItem.Click += purpleToolStripMenuItem_Click_1;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // TaskKiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 279);
            Controls.Add(label1);
            Controls.Add(txtProcessName);
            Controls.Add(btnKillProcess);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TaskKiller";
            Text = "TaskKiller";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKillProcess;
        private TextBox txtProcessName;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}