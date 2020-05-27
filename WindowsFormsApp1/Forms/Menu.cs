using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    //Форма меню
    public partial class Menu : Form
    {
        protected Menu()
        {
            InitializeComponent();
        }
        
        //Обробка події закриття форми
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.Prison.Save();
        }

        //Обробка події після закриття форми
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Обробка події натискання на елемент меню "Головна"
        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.Main.Show();
        }

        //Обробка події натискання на елемент меню "Статистика"
        private void StatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.Statistics.Show();
        }
    }
}