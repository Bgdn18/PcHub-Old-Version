using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHUB
{
    public partial class AdminApps : Form
    {
        public AdminApps()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.CMD.Click += PCHUBcmd.CMD_Click; // Привязка к методу из AdminApps
            this.AddLocalUser.Click += PCHUBlocalUser.LocalUser_Click; // Привязка к методу из AdminApps
        }
        private Library PCHUBcmd = new Library();
        private Library PCHUBlocalUser = new Library();

        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 

        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
        }
        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
        private void AdminApps_Load(object sender, EventArgs e)
        {

        }

        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); // Создаем новый экземпляр Form2
            about.Show(); // Открываем Form2 как независимую форму
        }
        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 

        //TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР 
        private void TxtWriter_Click(object sender, EventArgs e)
        {
            TextFileCreator txt = new TextFileCreator(); // Создаем новый экземпляр Form2
            txt.Show(); // Открываем Form2 как независимую форму

        }
        //TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР

        //RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR 
        private void RESOURCEMONITOR_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }
        //RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR 

        //EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER 
        private void EXPLORER_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Explorer",
                    Filter = "All|*.*"  // Показывает все файлы, в фильтре просто "All"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFileSysWow64 = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        //EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER 

        //CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL
        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe");
        }
        //CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL CONTROL PANEL

        //REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT 
        private void REGEDIT_Click(object sender, EventArgs e)
        {
            Process.Start("regedit.exe");
        }
        //REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT REGEDIT 

        //CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD 
        private void CMD_Click(object sender, EventArgs e)
        {
        }
        //CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD 


        //111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Получение пути к директории, где находится исполняемый файл pchub
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Укажите относительный путь к папке CUSTOMCMD
            string customCmdDirectory = Path.Combine(hubDirectory, "CUSTOMCMD");

            // Формирование полного пути к Automated Console.exe
            string customCmdPath = Path.Combine(customCmdDirectory, "Automated Console.exe");

            Process.Start(customCmdPath);
            this.Close();
        }
        //111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 111CUSTOM CMD!!! 

        private void ExplorerPP_Click(object sender, EventArgs e)
        {
            // Получение пути к директории, где находится исполняемый файл pchub
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Укажите относительный путь к папке CUSTOMCMD
            string customCmdDirectory = Path.Combine(hubDirectory, "ExplorerPP");

            // Формирование полного пути к Automated Console.exe
            string customCmdPath = Path.Combine(customCmdDirectory, "Explorer++.exe");

            Process.Start(customCmdPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение пути к директории, где находится исполняемый файл pchub
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Укажите относительный путь к папке CUSTOMCMD
            string customCmdDirectory = Path.Combine(hubDirectory, "Process Hacker 2");

            // Формирование полного пути к Automated Console.exe
            string customCmdPath = Path.Combine(customCmdDirectory, "ProcessHacker.exe");

            Process.Start(customCmdPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получение пути к директории, где находится исполняемый файл pchub
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Укажите относительный путь к папке CUSTOMCMD
            string customCmdDirectory = Path.Combine(hubDirectory, "IObit");

            // Укажите относительный путь к папке CUSTOMCMD
            string IoBit = Path.Combine(customCmdDirectory, "IObit Unlocker");

            // Формирование полного пути к Automated Console.exe
            string IoBitUnlockerExe = Path.Combine(IoBit, "IObitUnlocker.exe");

            Process.Start(IoBitUnlockerExe);
        }

        public void LocalUser_Click(object? sender, EventArgs e)
        {
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.Show();
            this.Close();
        }

        private void TaskMgrControl_Click(object sender, EventArgs e)
        {
            TaskMgrControl mgr = new TaskMgrControl();
            mgr.Show();
        }
    }
}