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
        }
        Library PcHub = new Library();


        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcHub.build();
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            PcHub.writer();

        }

        private void RESOURCEMONITOR_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }

        private void EXPLORER_Click(object sender, EventArgs e)
        {
            PcHub.fileexplorer();
        }

        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe");
        }

        private void REGEDIT_Click(object sender, EventArgs e)
        {
            Process.Start("regedit.exe");
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            PcHub.cmd();
        }



        private void ExplorerPP_Click(object sender, EventArgs e)
        {
            PcHub.explorerpp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PcHub.procceshacker();
        }

        private void IObitUnlocker_Click(object sender, EventArgs e)
        {
            PcHub.unlocker();
        }

        public void LocalUser_Click(object? sender, EventArgs e)
        {
            PcHub.localuser();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskMgrUnlocker_Click(object sender, EventArgs e)
        {
            PcHub.taskmgrunlocker();
        }
    }
}