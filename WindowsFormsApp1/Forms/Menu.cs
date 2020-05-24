using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Menu : Form
    {
        protected Menu()
        {
            InitializeComponent();
        }
        
        
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.Prison.Save();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.Main.Show();
        }

        private void StatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.Statistics.Show();
        }
    }
}