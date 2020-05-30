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
            
            Global.Prison.Load();
        }

        //Обробка події натискання на кнопку "Увійти як гість"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.Main = new Main();
            Global.Main.Show();
        }

        //Обробка події натискання на кнопку "Увійти"
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == Global.Prison.Password)
            {
                this.Hide();
                Global.Main = new MainLord();
                Global.Main.Show();
            }
            else
            {
                MessageBox.Show("Введено невірний пароль. Спробуйте знову.");
            }
        }
    }
}
