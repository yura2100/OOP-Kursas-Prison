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
    //Форма авторізації
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Обробка події натискання на кнопку "Увійти як гість"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.Main = new Main();
            Global.Main.Show();
            Global.Prison.Load();
        }

        //Обробка події натискання на кнопку "Увійти"
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "1")
            {
                this.Hide();
                Global.Main = new MainLord();
                Global.Main.Show();
                Global.Prison.Load();
            }
            else
            {
                MessageBox.Show("Введено невірний пароль. Спробуйте знову.");
            }
        }
    }
}
