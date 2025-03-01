using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHUB
{
    public partial class PowerManagement : Form
    {
        public PowerManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }

        private void toHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN ToHub = new MAIN(); // Создаем новый экземпляр Form2
            ToHub.Show(); // Открываем Form2 как независимую форму
            this.Hide(); // Скрываем текущую форму (Form1), а не закрываем её
        }
    }
}
