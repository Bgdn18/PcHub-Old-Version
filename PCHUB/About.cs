using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace PCHUB
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN Main = new MAIN(); // Создаем новый экземпляр Form2
            Main.Show(); // Открываем Form2 как независимую форму
            this.Hide(); // Скрываем текущую форму (Form1), а не закрываем её
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
