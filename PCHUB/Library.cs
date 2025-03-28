using System.Diagnostics;

namespace PCHUB
{
    public partial class Library : Form
    {
        public Library()
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

        //CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD CMD 
        public void CMD_Click(object? sender, EventArgs e)
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
        }
        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 

        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
        }
        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 

        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); // Создаем новый экземпляр Form2
            about.Show();
        }
        //ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU ABOUT MENU 

        //TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР 
        private void TxtWriter_Click(object sender, EventArgs e)
        {
            TextFileCreator txt = new TextFileCreator(); // Создаем новый экземпляр Form2
            txt.Show(); // Открываем Form2 как независимую форму
        }
        //TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР TXT РЕДАКТОР 

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
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            Browse browser = new Browse(); // Создаем новый экземпляр Form2
            browser.Show(); // Открываем Form2 как независимую форму
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            TaskKiller killer = new TaskKiller(); // Создаем новый экземпляр Form2
            killer.Show(); // Открываем Form2 как независимую форму
        }

        public void FileExplorer_Click(object? sender, EventArgs e)
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

        public void LocalUser_Click(object? sender, EventArgs e)
        {
            LocalUser Localusercreate = new LocalUser();
            Localusercreate.Show();
        }

        public void ExplorerPP_Click(object? sender, EventArgs e)
        {
            // Получение пути к директории, где находится исполняемый файл pchub
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Укажите относительный путь к папке CUSTOMCMD
            string customCmdDirectory = Path.Combine(hubDirectory, "ExplorerPP");

            // Формирование полного пути к Automated Console.exe
            string customCmdPath = Path.Combine(customCmdDirectory, "Explorer++.exe");

            Process.Start(customCmdPath);
        }

        public void WindowsSettings_Click(object? sender, EventArgs e)
        {
            //Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings 
            try
            {
                Process.Start("explorer.exe", "ms-settings:");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening settings: " + ex.Message);
            }
            //Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings Settings 
        }

        private void buildhelp_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.Show();
            this.Close();
        }

        public void PowerMgr_Click(object? sender, EventArgs e)
        {
            PowerManagement power = new PowerManagement();
            power.Show();
        }

        private void TaskMgrControl_Click(object sender, EventArgs e)
        {
            TaskMgrControl Taskmgr = new TaskMgrControl();
            Taskmgr.Show();
        }

        private void HostsFile_Click(object sender, EventArgs e)
        {
            HostsFile hostfile = new HostsFile();
            hostfile.Show();
        }

        private void PowerShellPolicyManager_Click(object sender, EventArgs e)
        {
            PowerShellPolicyReset powershellreset = new PowerShellPolicyReset();
            powershellreset.Show();
        }
    }
}
