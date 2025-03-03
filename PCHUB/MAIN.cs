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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PCHUB
{


    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void PowerManagement_Click(object sender, EventArgs e)
        {
            PowerManagement power = new PowerManagement();
            power.Show();
            this.Hide();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); // Создаем новый экземпляр Form2
            about.Show(); // Открываем Form2 как независимую форму
        }
        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 

        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 
        private void whiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            CUSTOMCMD_TEXT.ForeColor = Color.Black;
            ADDTXTFILE_TEXT.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.Silver;
        }
        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 

        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
        private void purpleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
            CUSTOMCMD_TEXT.ForeColor = Color.White;
            ADDTXTFILE_TEXT.ForeColor = Color.White;
            menuStrip1.BackColor = Color.Purple;
        }
        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 


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


        private void ALL_Click(object sender, EventArgs e)
        {
            PcHub all = new PcHub(); // Создаем новый экземпляр Form2
            all.Show(); // Открываем Form2 как независимую форму
        }


        //TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР 
        private void TxtWriter_Click(object sender, EventArgs e)
        {
            TextFileCreator txt = new TextFileCreator(); // Создаем новый экземпляр Form2
            txt.Show(); // Открываем Form2 как независимую форму
        }
        //TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР 

        //PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS 
        private void Programs_Click(object sender, EventArgs e)
        {
            Programs programs = new Programs(); // Создаем новый экземпляр Form2
            programs.Show(); // Открываем Form2 как независимую форму
        }
        //PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS PROGRAMS 

        //ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS 
        private void ADMIN_Click(object sender, EventArgs e)
        {
            AdminApps adminapps = new AdminApps(); // Создаем новый экземпляр Form2
            adminapps.Show(); // Открываем Form2 как независимую форму
        }
        //ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS ADMIN APPS 

        //CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD 
        private void CMD_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                UseShellExecute = true,
                WorkingDirectory = @"C:\",
                Arguments = "/k color 4 & help",
            };

            Process.Start(startInfo);
        }
        //CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD 

        //Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings 
        private void Settings_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Process.Start("explorer.exe", "ms-settings:");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии параметров: " + ex.Message);
                }
                //Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings 


            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Browse Browse = new Browse();
            Browse.Show();
        }


        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 

        //TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER 
        private void Taskkiller_Click(object sender, EventArgs e)
        {
            TaskKiller killer = new TaskKiller();
            killer.Show();
        }

        private void YOUTUBE_Click(object sender, EventArgs e)
        {
            YouTube YouTube = new YouTube();
            YouTube.Show();
        }

        private void build_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void ADDTXTFILE_TEXT_Click(object sender, EventArgs e)
        {
            TextFileCreator txtfile = new TextFileCreator();
            txtfile.Show();
        }
        //TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER TASKKILLER 

    }
}