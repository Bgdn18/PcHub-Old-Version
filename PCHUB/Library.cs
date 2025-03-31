using System.Diagnostics;
using Microsoft.Win32;

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


        //Название Приложения!!!
        public class AppnamePcHub
        {
            public const string AppName = "PCHUB";
        }




        public void ZAPRET_Click(object sender, EventArgs e)
        {
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string Zapretpath = Path.Combine(hubDirectory, "ZAPRET");

            string ZAPRET = Path.Combine(Zapretpath, "ZAPRET.bat");

            try
            {
                Process.Start(ZAPRET);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error opening Zapret: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CMD_Click(object? sender, EventArgs e)
        {
            cmd();
        }

        public void cmd()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                UseShellExecute = true,
                WorkingDirectory = @"C:\",
                Arguments = "/k color 3 & help",
            };
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening cmd: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EXPLORER_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Explorer.exe maybe it is blocked, try to unblock it in the TaskManagerControl tab: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("control.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening ControlPanel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void REGEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("regedit.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening RegEdit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {
            taskmgr();
        }


        public void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        public void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            build();
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            writer();
        }

        public void Browse_Click(object sender, EventArgs e)
        {
            browser();
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            taskkill();
        }

        private void FileExplorer_Click(object? sender, EventArgs e)
        {
            fileexplorer();
        }

        private void btnProccesHacker_Click(object sender, EventArgs e)
        {
            procceshacker();
        }

        private void btnLocalUser_Click(object? sender, EventArgs e)
        {
            localuser();
        }

        private void btnExplorerPP_Click(object? sender, EventArgs e)
        {
            explorerpp(); //explorer++
        }

        private void btnWindowsSettings_Click(object? sender, EventArgs e)
        {
            settings();
        }

        private void btnbuildhelp_Click(object sender, EventArgs e)
        {
            build();
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quit();
        }

        private void btnPowerMgr_Click(object? sender, EventArgs e)
        {
            powermgr();
        }

        public void btnTaskMgrUnlocker_Click(object sender, EventArgs e)
        {
            taskmgrunlocker();
        }

        public void btnHostsFile_Click(object sender, EventArgs e)
        {
            HostsFile();
        }

        public void btnPowerShellPolicyManager_Click(object sender, EventArgs e)
        {
            powershellpolicymgr();
        }

        private void btnIObitUnlocker_Click(object? sender, EventArgs e)
        {
            unlocker();
        }

        public void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addtostartup();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removefromstartup();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            main();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            tools();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            library();
        }













        public void tools()
        {
            AdminApps adminapps = new AdminApps();
            try
            {
                adminapps.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void library()
        {
            Library library = new Library();
            try
            {
                library.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void main() // Открывает Форму MAIN (Начальную)
        {
            _MAIN main = new _MAIN();
            try
            {
                main.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void removefromstartup() // Удаление Из Автозагрузки
        {
            try
            {
                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key?.GetValue(AppnamePcHub.AppName) == null)
                    {
                        MessageBox.Show("The program was not in startup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    key.DeleteValue(AppnamePcHub.AppName);
                    MessageBox.Show("The program has been removed from startup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addtostartup() // Добавляет В Автозагрузку
        {
            try
            {
                string exePath = Application.ExecutablePath;

                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key?.GetValue(AppnamePcHub.AppName) != null)
                    {
                        MessageBox.Show("The program is already in startup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    key?.SetValue(AppnamePcHub.AppName, exePath);
                    MessageBox.Show("The program has been successfully added to startup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void unlocker() // Открывает IObit unlocker
        {
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string customCmdDirectory = Path.Combine(hubDirectory, "IObit");

            string IoBit = Path.Combine(customCmdDirectory, "IObit Unlocker");

            string IoBitUnlockerExe = Path.Combine(IoBit, "IObitUnlocker.exe");
            try
            {
                Process.Start(IoBitUnlockerExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening IObit Unlocker maybe it is missing from the application folder ?" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void powershellpolicymgr() // Открывает Менеджер По Политике PowerShell
        {
            PowerShellPolicyReset powershellreset = new PowerShellPolicyReset();
            try
            {
                powershellreset.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening PowerShellReset: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HostsFile() // Открывает Файл Hosts
        {
            HostsFile hostfile = new HostsFile();
            try
            {
                hostfile.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening HostFile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void taskmgrunlocker() // Открывает Разблокировщик Диспетчера Задач
        {
            TaskMgrControl Taskmgr = new TaskMgrControl();
            try
            {
                Taskmgr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening TaskMgrControl: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void powermgr() // Открывает  Управление Питанием (Не Работает В Среде Ввостановления)
        {
            PowerManagement power = new PowerManagement();
            try
            {
                power.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening PowerMgr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void build() // Открывает Информацию О Билде
        {
            About about = new About();
            try
            {
                about.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening About: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void settings() // Открывает Настройки Windows
        {
            try
            {
                Process.Start("explorer.exe", "ms-settings:");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void explorerpp() // Открывает Проводник++
        {
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string customCmdDirectory = Path.Combine(hubDirectory, "ExplorerPP");

            string customCmdPath = Path.Combine(customCmdDirectory, "Explorer++.exe");

            try
            {
                Process.Start(customCmdPath);
            }
            catch
            {
                MessageBox.Show("Error opening Explorer++ maybe it is missing from the application folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void localuser() // Открывает Добавление Локального Пользователя
        {
            LocalUser Localusercreate = new LocalUser();
            try
            {
                Localusercreate.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening LocalUserCreate" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void procceshacker() // Открывает Проццес Хакер
        {
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string procceshackerfolder = Path.Combine(hubDirectory, "Process Hacker 2");

            string ProccesHacker = Path.Combine(procceshackerfolder, "ProcessHacker.exe");

            try
            {
                Process.Start(ProccesHacker);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening IObit Unlocker maybe it is missing from the application folder ?" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fileexplorer() // Открывает Проводник Который Может Быть Полезен В Среде Ввостановления
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Explorer",
                    Filter = "All|*.*"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFileSysWow64 = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void taskkill() // Открывает Снятие Задач
        {
            TaskKiller killer = new TaskKiller();
            try
            {
                killer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening TaskKiller: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void browser() // Открывает Искатель По Браузеру
        {
            Browse browser = new Browse();
            try
            {
                browser.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening Browser: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void writer() // Открывает Писатель
        {
            TextFileCreator txt = new TextFileCreator();
            try
            {
                txt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening Writer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void taskmgr() // Диспетчер Задач
        {
            try
            {
                Process.Start("taskmgr.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening task manager: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void quit() // Выход Из Приложения
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Quit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
