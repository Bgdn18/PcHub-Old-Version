namespace PCHUB
{
    partial class LocalUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalUser));
            ADDLocalUser = new Button();
            DeleteLocalUser = new Button();
            textboxUsername = new TextBox();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            ViewFolder = new Button();
            UserPassword = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ADDLocalUser
            // 
            ADDLocalUser.Font = new Font("Consolas", 9F);
            ADDLocalUser.Location = new Point(12, 133);
            ADDLocalUser.Name = "ADDLocalUser";
            ADDLocalUser.Size = new Size(125, 60);
            ADDLocalUser.TabIndex = 0;
            ADDLocalUser.Text = "ADD";
            ADDLocalUser.UseVisualStyleBackColor = true;
            ADDLocalUser.Click += button1_Click;
            // 
            // DeleteLocalUser
            // 
            DeleteLocalUser.Font = new Font("Consolas", 9F);
            DeleteLocalUser.Location = new Point(143, 133);
            DeleteLocalUser.Name = "DeleteLocalUser";
            DeleteLocalUser.Size = new Size(125, 60);
            DeleteLocalUser.TabIndex = 1;
            DeleteLocalUser.Text = "DELETE";
            DeleteLocalUser.UseVisualStyleBackColor = true;
            DeleteLocalUser.Click += DeleteLocalUser_Click;
            // 
            // textboxUsername
            // 
            textboxUsername.Font = new Font("Consolas", 9F);
            textboxUsername.Location = new Point(12, 46);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.PlaceholderText = "UserName";
            textboxUsername.Size = new Size(452, 22);
            textboxUsername.TabIndex = 2;
            textboxUsername.Text = "PCHUB USER";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonShadow;
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(477, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Font = new Font("Consolas", 9F);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(54, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Font = new Font("Consolas", 9F);
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(47, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // ViewFolder
            // 
            ViewFolder.Font = new Font("Consolas", 9F);
            ViewFolder.Location = new Point(340, 133);
            ViewFolder.Name = "ViewFolder";
            ViewFolder.Size = new Size(125, 60);
            ViewFolder.TabIndex = 4;
            ViewFolder.Text = "View Folder";
            ViewFolder.UseVisualStyleBackColor = true;
            ViewFolder.Click += ViewFolder_Click;
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Consolas", 9F);
            UserPassword.Location = new Point(13, 74);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.PlaceholderText = "PassWord";
            UserPassword.Size = new Size(452, 22);
            UserPassword.TabIndex = 5;
            // 
            // LocalUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 205);
            Controls.Add(UserPassword);
            Controls.Add(ViewFolder);
            Controls.Add(textboxUsername);
            Controls.Add(DeleteLocalUser);
            Controls.Add(ADDLocalUser);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LocalUser";
            ShowIcon = false;
            Text = "LocalUser Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ADDLocalUser;
        private Button DeleteLocalUser;
        private TextBox textboxUsername;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button ViewFolder;
        private TextBox UserPassword;
    }
}