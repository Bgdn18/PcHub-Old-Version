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
    public partial class Programs : Form
    {
        public Programs()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Programs_Load(object sender, EventArgs e)
        {

        }

        //ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET 
        private void ZAPRET_Click(object sender, EventArgs e)
        {
            Process.Start("\"E:\\Моё\\zapret\\zapret-discord-youtube-1.6.2\\general.bat\"");
        }
        //ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET ZAPRET 

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); // Создаем новый экземпляр Form2
            about.Show(); // Открываем Form2 как независимую форму
        }

        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 
        private void toHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN ToHub = new MAIN(); // Создаем новый экземпляр Form2
            ToHub.Show(); // Открываем Form2 как независимую форму
            this.Close(); // Скрываем текущую форму (Form1), а не закрываем её
        }
        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 

        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT EXIT 


        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browse browser = new Browse(); // Создаем новый экземпляр Form2
            browser.Show(); // Открываем Form2 как независимую форму
            this.Close();
        }
    }
}
