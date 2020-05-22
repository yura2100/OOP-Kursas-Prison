using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void StatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics f = new Statistics();
            f.Show();
            this.Hide();
        }
    }
}