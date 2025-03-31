namespace PCHUB
{
    public partial class _MAIN : Form
    {
        public _MAIN()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        //Library объявление
        Library PcHub = new Library();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcHub.build(); //билд
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            menuStrip1.BackColor = Color.Silver;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
            menuStrip1.BackColor = Color.Purple;
        }

        private void Library_Click(object sender, EventArgs e)
        {
            PcHub.library();
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            TextFileCreator txt = new TextFileCreator();
            txt.Show();
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            PcHub.tools();
        }

        private void LocalUser_Click(object sender, EventArgs e)
        {
            PcHub.localuser();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcHub.quit();
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            PcHub.taskkill();
        }

        private void build_Click(object sender, EventArgs e)
        {
            PcHub.build();
        }

        private void ADDTXTFILE_TEXT_Click(object sender, EventArgs e)
        {
            PcHub.writer();
        }

        private void PowerManagement_Click(object sender, EventArgs e)
        {
            PcHub.powermgr();
        }
        public void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcHub.addtostartup();
        }

        public void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcHub.removefromstartup();
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            PcHub.cmd();
        }

        private void IOBitUnlocker_Click(object sender, EventArgs e)
        {
            PcHub.unlocker();
        }

        private void WindowsSettings_Click(object sender, EventArgs e)
        {
            PcHub.settings();
        }

        private void ExplorerPP_Click(object sender, EventArgs e)
        {
            PcHub.explorerpp();
        }

        private void fileexplorer_Click(object sender, EventArgs e)
        {
            PcHub.fileexplorer();
        }
    }
}