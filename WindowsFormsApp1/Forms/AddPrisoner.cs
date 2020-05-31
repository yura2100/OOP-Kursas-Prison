using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    //Форма додавання нового в'язня
    public partial class AddPrisoner : Form
    {
        public AddPrisoner()
        {
            InitializeComponent();
        }

        //Обробка події натискання на кнопку "Додати нового в'язня"
        private void buttonAddPrisoner_Click(object sender, EventArgs e)
        {
            bool fail = this.Controls.OfType<TextBox>().Any(tb => tb.TextLength == 0);
            if (!fail)
            {
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                string patronymic = textBoxPatronymic.Text;
                DateTime birthDate = dateTimePickerBirth.Value;
                DateTime guardDate = dateTimePickerGuard.Value;

                try
                {
                    int years = Int32.Parse(textBoxYears.Text);
                    int months = Int32.Parse(textBoxMonths.Text);
                    int days = Int32.Parse(textBoxDays.Text);

                    if (Global.Codex.ContainsKey(comboBoxStateNumber.Text))
                    {
                        string stateNumber = comboBoxStateNumber.Text;
                        
                        Global.Prison.Add(name, surname, patronymic, birthDate, stateNumber, guardDate, years, months, days);
                        Global.Main.UpdateListView(Global.Prison.Prisoners);
                        
                        this.Close();
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Введен невірний аргумент");
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі поля");
            }
        }
    }
}