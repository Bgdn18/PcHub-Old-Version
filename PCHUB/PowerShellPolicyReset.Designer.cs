namespace PCHUB
{
    partial class PowerShellPolicyReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerShellPolicyReset));
            lblCurrentPolicy = new Label();
            btnResetPolicy = new Button();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // lblCurrentPolicy
            // 
            lblCurrentPolicy.AutoSize = true;
            lblCurrentPolicy.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPolicy.Location = new Point(12, 9);
            lblCurrentPolicy.Name = "lblCurrentPolicy";
            lblCurrentPolicy.Size = new Size(240, 22);
            lblCurrentPolicy.TabIndex = 0;
            lblCurrentPolicy.Text = "Current policy: Unknown";
            // 
            // btnResetPolicy
            // 
            btnResetPolicy.Font = new Font("Consolas", 9F);
            btnResetPolicy.Location = new Point(12, 46);
            btnResetPolicy.Name = "btnResetPolicy";
            btnResetPolicy.Size = new Size(235, 55);
            btnResetPolicy.TabIndex = 1;
            btnResetPolicy.Text = "Reset policy";
            btnResetPolicy.UseVisualStyleBackColor = true;
            btnResetPolicy.Click += btnResetPolicy_Click;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Consolas", 9F);
            btnCheck.Location = new Point(253, 46);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(235, 55);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check current policy";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // PowerShellPolicyReset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 120);
            Controls.Add(btnCheck);
            Controls.Add(btnResetPolicy);
            Controls.Add(lblCurrentPolicy);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PowerShellPolicyReset";
            Text = "PowerShell Policy Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentPolicy;
        private Button btnResetPolicy;
        private Button btnCheck;
    }
}