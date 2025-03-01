namespace PCHUB
{
    partial class TextFileCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFileCreator));
            txtFilePath = new TextBox();
            btnCreateFile = new Button();
            lblStatus = new Label();
            txtFileName = new TextBox();
            txtFileContent = new TextBox();
            menuStrip1 = new MenuStrip();
            themesToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtFilePath.Location = new Point(12, 28);
            txtFilePath.Multiline = true;
            txtFilePath.Name = "txtFilePath";
            txtFilePath.PlaceholderText = "TXT Path";
            txtFilePath.Size = new Size(621, 27);
            txtFilePath.TabIndex = 0;
            // 
            // btnCreateFile
            // 
            btnCreateFile.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateFile.Location = new Point(639, 28);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(344, 63);
            btnCreateFile.TabIndex = 1;
            btnCreateFile.Text = "Create TXT File";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(639, 582);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(344, 17);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "STATUS STATUS STATUS STATUS STATUS STATUS STATUS ";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(12, 68);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.PlaceholderText = "TXT Name";
            txtFileName.Size = new Size(621, 27);
            txtFileName.TabIndex = 3;
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // txtFileContent
            // 
            txtFileContent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtFileContent.Location = new Point(12, 101);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.PlaceholderText = "TXT File";
            txtFileContent.Size = new Size(621, 498);
            txtFileContent.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { themesToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 24);
            menuStrip1.TabIndex = 5;
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
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(639, 101);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 6;
            label1.Text = "Use \"\" for hidden file\r\n";
            // 
            // TextFileCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 611);
            Controls.Add(label1);
            Controls.Add(txtFileContent);
            Controls.Add(txtFileName);
            Controls.Add(lblStatus);
            Controls.Add(btnCreateFile);
            Controls.Add(txtFilePath);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TextFileCreator";
            Text = "TextFileCreator";
            Load += TextFileCreator_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnCreateFile;
        private Label lblStatus;
        private TextBox txtFileName;
        private TextBox txtFileContent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label label1;
    }
}