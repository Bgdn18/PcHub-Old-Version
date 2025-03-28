using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
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

        //EASTER EGGEASTER EGG EASTER EGG EASTER EGG EASTER EGG EASTER EGG EASTER EGG EASTER EGG 
        private void label2_Click(object sender, EventArgs e)
        {
            this.Text = ("About kostyan edition");

            Random rand = new Random();

                this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                ABOUTTEXT.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                PCHUB.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                label2.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                ABOUTTEXT.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                PCHUB.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                label2.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

        }
        //EASTER EGG EASTER EGG EASTER EGG EASTER EGG EASTER EGG EASTER EGG EASTER EGG EASTER EGG
    }
}
