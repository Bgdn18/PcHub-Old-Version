﻿namespace PCHUB
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
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            listBoxProcesses = new ListBox();
            TasksLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRunNewProcess = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            labelAutoStartCount = new Label();
            btnAddAutoStart = new Button();
            btnDeleteAutoStart = new Button();
            btnRefreshAutoStart = new Button();
            startupListView = new ListBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // btnKillProcess
            // 
            btnKillProcess.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKillProcess.Location = new Point(12, 174);
            btnKillProcess.Name = "btnKillProcess";
            btnKillProcess.Size = new Size(776, 59);
            btnKillProcess.TabIndex = 0;
            btnKillProcess.Text = "KILL";
            btnKillProcess.UseVisualStyleBackColor = true;
            btnKillProcess.Click += btnKillProcess_Click;
            // 
            // txtProcessName
            // 
            txtProcessName.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProcessName.Location = new Point(12, 37);
            txtProcessName.Multiline = true;
            txtProcessName.Name = "txtProcessName";
            txtProcessName.PlaceholderText = "Example -- PCHUB";
            txtProcessName.Size = new Size(776, 131);
            txtProcessName.TabIndex = 1;
            txtProcessName.Text = "PCHUB";
            // 
=======
>>>>>>> NewFeatureBranch
=======
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem, runToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
<<<<<<< HEAD
<<<<<<< HEAD
            menuStrip1.Size = new Size(800, 24);
=======
            menuStrip1.Size = new Size(569, 24);
>>>>>>> NewFeatureBranch
=======
            menuStrip1.Size = new Size(569, 24);
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
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
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click_1;
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(40, 20);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // listBoxProcesses
            // 
            listBoxProcesses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxProcesses.Font = new Font("Consolas", 9F);
            listBoxProcesses.FormattingEnabled = true;
            listBoxProcesses.ItemHeight = 14;
            listBoxProcesses.Location = new Point(6, 6);
            listBoxProcesses.Name = "listBoxProcesses";
            listBoxProcesses.Size = new Size(552, 396);
            listBoxProcesses.TabIndex = 4;
            // 
            // TasksLabel
            // 
            TasksLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TasksLabel.AutoSize = true;
            TasksLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TasksLabel.Location = new Point(119, 412);
            TasksLabel.Name = "TasksLabel";
            TasksLabel.Size = new Size(98, 14);
            TasksLabel.TabIndex = 6;
            TasksLabel.Text = "Process: null";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(569, 463);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRunNewProcess);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(listBoxProcesses);
            tabPage1.Controls.Add(TasksLabel);
            tabPage1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(561, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Procces";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRunNewProcess
            // 
            btnRunNewProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRunNewProcess.Location = new Point(6, 408);
            btnRunNewProcess.Name = "btnRunNewProcess";
            btnRunNewProcess.Size = new Size(107, 23);
            btnRunNewProcess.TabIndex = 9;
            btnRunNewProcess.Text = "Run";
            btnRunNewProcess.UseVisualStyleBackColor = true;
            btnRunNewProcess.Click += runToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(397, 408);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(478, 408);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "End Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnKillProcess_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelAutoStartCount);
            tabPage2.Controls.Add(btnAddAutoStart);
            tabPage2.Controls.Add(btnDeleteAutoStart);
            tabPage2.Controls.Add(btnRefreshAutoStart);
            tabPage2.Controls.Add(startupListView);
            tabPage2.Font = new Font("Consolas", 9F);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(561, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AutoStartup";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelAutoStartCount
            // 
            labelAutoStartCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelAutoStartCount.AutoSize = true;
            labelAutoStartCount.Font = new Font("Consolas", 9F, FontStyle.Bold);
            labelAutoStartCount.Location = new Point(119, 413);
            labelAutoStartCount.Name = "labelAutoStartCount";
            labelAutoStartCount.Size = new Size(98, 14);
            labelAutoStartCount.TabIndex = 4;
            labelAutoStartCount.Text = "Process: null";
            // 
            // btnAddAutoStart
            // 
            btnAddAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddAutoStart.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAutoStart.Location = new Point(6, 409);
            btnAddAutoStart.Name = "btnAddAutoStart";
            btnAddAutoStart.Size = new Size(107, 23);
            btnAddAutoStart.TabIndex = 3;
            btnAddAutoStart.Text = "Add Auto Start";
            btnAddAutoStart.UseVisualStyleBackColor = true;
            btnAddAutoStart.Click += btnAddAutoStart_Click;
            // 
            // btnDeleteAutoStart
            // 
            btnDeleteAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteAutoStart.Location = new Point(478, 409);
            btnDeleteAutoStart.Name = "btnDeleteAutoStart";
            btnDeleteAutoStart.Size = new Size(75, 23);
            btnDeleteAutoStart.TabIndex = 2;
            btnDeleteAutoStart.Text = "Delete";
            btnDeleteAutoStart.UseVisualStyleBackColor = true;
            btnDeleteAutoStart.Click += btnDeleteAutoStart_Click;
            // 
            // btnRefreshAutoStart
            // 
            btnRefreshAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefreshAutoStart.Location = new Point(397, 409);
            btnRefreshAutoStart.Name = "btnRefreshAutoStart";
            btnRefreshAutoStart.Size = new Size(75, 23);
            btnRefreshAutoStart.TabIndex = 1;
            btnRefreshAutoStart.Text = "Refresh";
            btnRefreshAutoStart.UseVisualStyleBackColor = true;
            btnRefreshAutoStart.Click += btnRefreshAutoStart_Click;
            // 
            // startupListView
            // 
            startupListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startupListView.FormattingEnabled = true;
            startupListView.ItemHeight = 14;
            startupListView.Location = new Point(6, 6);
            startupListView.Name = "startupListView";
            startupListView.Size = new Size(547, 396);
            startupListView.TabIndex = 0;
            // 
            // TaskKiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
<<<<<<< HEAD
            ClientSize = new Size(800, 245);
            Controls.Add(txtProcessName);
            Controls.Add(btnKillProcess);
=======
            ClientSize = new Size(569, 490);
            Controls.Add(tabControl1);
>>>>>>> NewFeatureBranch
=======
            ClientSize = new Size(569, 490);
            Controls.Add(tabControl1);
>>>>>>> eecdd45 (улучшена логика в _list добавлен совершенно новый taskkiller)
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new Size(300, 300);
            Name = "TaskKiller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskKiller";
            Load += TaskKiller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ListBox listBoxProcesses;
        private Label TasksLabel;
        private ToolStripMenuItem runToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private Button button1;
        private Button btnRefreshAutoStart;
        private Button btnDeleteAutoStart;
        private Button btnAddAutoStart;
        private Label labelAutoStartCount;
        private ListBox startupListView;
        private Button btnRunNewProcess;
    }
}