using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PCHUB
{
    public partial class PowerShellPolicyReset : Form
    {
        public PowerShellPolicyReset()
        {
            InitializeComponent();
            CheckCurrentPolicy();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        // Проверка текущей политики выполнения через CMD
        private void CheckCurrentPolicy()
        {
            try
            {
                var process = new Process
                {
                    StartInfo = {
                        FileName = "cmd.exe",
                        Arguments = "/c powershell Get-ExecutionPolicy -Scope CurrentUser",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Verb = "runas" // Запуск от администратора
                    }
                };

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                lblCurrentPolicy.Text = output.Contains("Unrestricted")
                    ? "Current policy: Allowed"
                    : "Current policy: Blocked";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Кнопка сброса политики
        private void btnResetPolicy_Click(object sender, EventArgs e)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = {
                        FileName = "cmd.exe",
                        Arguments = "/c powershell Set-ExecutionPolicy Unrestricted -Scope CurrentUser -Force",
                        Verb = "runas",
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                };

                process.Start();
                process.WaitForExit();
                CheckCurrentPolicy();

                MessageBox.Show("Execution policy reset!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}