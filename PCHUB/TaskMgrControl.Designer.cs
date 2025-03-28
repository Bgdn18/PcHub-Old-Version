namespace PCHUB
{
    partial class TaskMgrControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskMgrControl));
            btnUnlock = new Button();
            btnLock = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUnlock
            // 
            btnUnlock.Font = new Font("Consolas", 9F);
            btnUnlock.Location = new Point(12, 62);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(185, 55);
            btnUnlock.TabIndex = 0;
            btnUnlock.Text = "Unlock";
            btnUnlock.UseVisualStyleBackColor = true;
            btnUnlock.Click += btnUnlock_Click;
            // 
            // btnLock
            // 
            btnLock.Font = new Font("Consolas", 9F);
            btnLock.Location = new Point(257, 62);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(185, 55);
            btnLock.TabIndex = 1;
            btnLock.Text = "Lock";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 24);
            label1.TabIndex = 2;
            label1.Text = "TaskMgr Control:";
            // 
            // TaskMgrControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 133);
            Controls.Add(label1);
            Controls.Add(btnLock);
            Controls.Add(btnUnlock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskMgrControl";
            Text = "TaskMgrControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUnlock;
        private Button btnLock;
        private Label label1;
    }
}