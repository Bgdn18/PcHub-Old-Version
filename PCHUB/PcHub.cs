using System.Diagnostics;

namespace PCHUB
{
    public partial class PcHub : Form
    {
        public PcHub()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        //ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET 
        private void ZAPRET_Click(object sender, EventArgs e)
        {
            // Получение пути к директории, где находится исполняемый файл pchub
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Укажите относительный путь к папке CUSTOMCMD
            string customCmdDirectory = Path.Combine(hubDirectory, "ZAPRET");

            // Формирование полного пути к Automated Console.exe
            string customCmdPath = Path.Combine(customCmdDirectory, "ZAPRET.bat");

            Process.Start(customCmdPath);
        }
        //ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET 

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

        //EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER EXPLORER 
        private void EXPLORER_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
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

        //RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR 
        private void RESOURCEMONITOR_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }
        //RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR RESOURCE MONITOR 

        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 
        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 

        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            label1.ForeColor = Color.Black;
        }
        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 

        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
            label1.ForeColor = Color.White;
        }
        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 

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


        private void label1_Click(object sender, EventArgs e)
        {

        }


        //BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER 
        private void Google_Click(object sender, EventArgs e)
        {
            // URL, который нужно открыть
            string url = "https://www.google.com";

            try
            {
                // Открытие браузера по умолчанию
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии браузера: " + ex.Message);
            }
        }
        //BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER BROWSER 
        private void PcHub_Load(object sender, EventArgs e)
        {

        }

        private void toHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN ToHub = new MAIN(); // Создаем новый экземпляр Form2
            ToHub.Show(); // Открываем Form2 как независимую форму
            this.Close(); // Скрываем текущую форму (Form1), а не закрываем её
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            Browse browser = new Browse(); // Создаем новый экземпляр Form2
            browser.Show(); // Открываем Form2 как независимую форму
            this.Close(); // Скрываем текущую форму (Form1), а не закрываем её
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            TaskKiller killer = new TaskKiller(); // Создаем новый экземпляр Form2
            killer.Show(); // Открываем Form2 как независимую форму
        }

        private void YouTube_Click(object sender, EventArgs e)
        {
            YouTube YouTube = new YouTube(); // Создаем новый экземпляр Form2
            YouTube.Show(); // Открываем Form2 как независимую форму
        }
    }
}
