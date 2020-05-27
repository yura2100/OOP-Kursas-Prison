using System;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    //Форма додавання нової риси характеру
    public partial class AddCharacter : Form
    {
        private Prisoner _prisoner;
        public AddCharacter(Prisoner prisoner)
        {
            InitializeComponent();
            this._prisoner = prisoner;
        }

        //Обробка події натискання на кнопку "Додати рису"
        private void button1_Click(object sender, EventArgs e)
        {
            bool fail = textBoxCharacter.TextLength == 0;
            if (!fail)
            {
                string character = textBoxCharacter.Text;
                _prisoner.Character.Add(character);
                Global.Main.UpdateCharacterList(_prisoner);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заповніть усі поля");
            }
        }
    }
}