using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
            Global.Prison.Load();
            // Prisoner p = new Prisoner("Ivan", "Ivanov", "Ivanovich", 1900, 12, 1, 1);
            // p.State = new State("123", 2018, 12, 11, 20, 11, 0);
            // Room r = new Room();
            // r.Number = 1;
            // r.Current = 1;
            // r.Max = 8;
            // p.Room = r;
            // Global.Prison.Prisoners.Add(p);
            // Global.Prison.Rooms.Add(r);
            // Global.Prison.CurentPrisoner = 1;
            // Global.Prison.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "12345678")
            {
                MainLord main = new MainLord();
                main.Show();
                this.Hide();
                Global.Prison.Load();
            }
            else
            {
                MessageBox.Show("Введено невірний пароль. Спробуйте знову.");
            }
        }
    }
}
