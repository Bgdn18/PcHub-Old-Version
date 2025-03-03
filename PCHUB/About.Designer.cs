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
            label1 = new Label();
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
            ABOUTTEXT.Size = new Size(306, 69);
            ABOUTTEXT.TabIndex = 0;
            ABOUTTEXT.Text = "Сделано \"Bogodan\" \r\nНамерено на личное использование.\r\nо а еще 1812 посхалка лол";
            // 
            // PCHUB
            // 
            PCHUB.AutoSize = true;
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
            build.Location = new Point(506, 182);
            build.Name = "build";
            build.Size = new Size(70, 20);
            build.TabIndex = 2;
            build.Text = "build 1.11";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(486, 57);
            label1.TabIndex = 3;
            label1.Text = "Вместе с продуктом в комплект должны идти \"Zapret\", \"CUSTOMCMD\" \r\nубедитесь что они находятся в корневой папке с PCHUB, \r\nэто гарантирует стабильность.";
            // 
            // label2
            // 
            label2.AutoSize = true;
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
            Controls.Add(label1);
            Controls.Add(build);
            Controls.Add(PCHUB);
            Controls.Add(ABOUTTEXT);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ABOUTTEXT;
        private Label PCHUB;
        private Label build;
        private Label label1;
        private Label label2;
    }
}