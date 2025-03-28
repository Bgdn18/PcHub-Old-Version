namespace PCHUB
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            ABOUTTEXT = new Label();
            PCHUB = new Label();
            build = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ABOUTTEXT
            // 
            ABOUTTEXT.AutoSize = true;
            ABOUTTEXT.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ABOUTTEXT.ForeColor = Color.FromArgb(64, 0, 64);
            ABOUTTEXT.Location = new Point(12, 9);
            ABOUTTEXT.Name = "ABOUTTEXT";
            ABOUTTEXT.Size = new Size(297, 23);
            ABOUTTEXT.TabIndex = 0;
            ABOUTTEXT.Text = "Сделано \"Bogodan\" для Nedohackers";
            // 
            // PCHUB
            // 
            PCHUB.AutoSize = true;
            PCHUB.Cursor = Cursors.Hand;
            PCHUB.Font = new Font("Constantia", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PCHUB.ForeColor = Color.Purple;
            PCHUB.Location = new Point(12, 157);
            PCHUB.Name = "PCHUB";
            PCHUB.Size = new Size(149, 45);
            PCHUB.TabIndex = 1;
            PCHUB.Text = "PCHUB";
            PCHUB.Click += label2_Click;
            // 
            // build
            // 
            build.AutoSize = true;
            build.BackColor = Color.Gray;
            build.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            build.ForeColor = Color.White;
            build.Location = new Point(459, 182);
            build.Name = "build";
            build.Size = new Size(117, 20);
            build.TabIndex = 2;
            build.Text = "BUILD: 3/5/2025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Constantia", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(427, 9);
            label2.Name = "label2";
            label2.Size = new Size(149, 45);
            label2.TabIndex = 4;
            label2.Text = "PCHUB";
            label2.Click += label2_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(588, 211);
            Controls.Add(label2);
            Controls.Add(build);
            Controls.Add(PCHUB);
            Controls.Add(ABOUTTEXT);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ABOUTTEXT;
        private Label PCHUB;
        private Label build;
        private Label label2;
    }
}