using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class AddRelative : Form
    {
        private Prisoner _prisoner;
        public AddRelative(Prisoner prisoner)
        {
            InitializeComponent();
            this._prisoner = prisoner;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool fail = this.Controls.OfType<TextBox>().Any(tb => tb.TextLength == 0);
            if (!fail)
            {
                Relative relative = new Relative(textBoxName.Text, textBoxSurname.Text, textBoxPatronymic.Text, textBoxType.Text);
                _prisoner.Relatives.Add(relative);
                Global.Main.UpdateRelativesList(_prisoner);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заповніть усі поля");
            }
        }
    }
}