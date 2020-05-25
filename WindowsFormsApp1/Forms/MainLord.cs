using System;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class MainLord : Main
    {
        private Prisoner _prisoner;
        public MainLord()
        {
            InitializeComponent();
        }

        protected override void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            base.listView1_MouseClick(sender, e);
            _prisoner = (Prisoner) listView1.SelectedItems[0].Tag;
            
        }

        private void buttonDeletePrisoner_Click(object sender, EventArgs e)
        {
            if (_prisoner != null)
            {
                DialogResult result = MessageBox.Show($"Ви впевнені, що бажаєте видалити в'язня № {_prisoner.ID}?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Global.Prison.Remove(_prisoner.ID);
                    UpdateListView(Global.Prison.Prisoners);
                }
            }
            else
            {
                MessageBox.Show("Спочатку треба вибрати в'язня");
            }
        }

        private void buttonAddRelative_Click(object sender, EventArgs e)
        {
            if (_prisoner != null)
            {
                AddRelative f = new AddRelative(_prisoner);
                f.Show();
            }
            else
            {
                MessageBox.Show("Спочатку треба вибрати в'язня");
            }
        }

        private void buttonDeleteRelative_Click(object sender, EventArgs e)
        {
            try
            {
                Relative relative = (Relative) listViewRelatives.SelectedItems[0].Tag;
                DialogResult result = MessageBox.Show("Ви впевнені, що бажаєте видалити цього родича?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _prisoner.Relatives.Remove(relative);
                    UpdateRelativesList(_prisoner);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Спочатку треба вибрати родича");
            }
        }
        
        private void buttonAddCharacter_Click_1(object sender, EventArgs e)
        {
            if (_prisoner != null)
            {
                AddCharacter f = new AddCharacter(_prisoner);
                f.Show();
            }
            else
            {
                MessageBox.Show("Спочатку треба вибрати в'язня");
            }
        }

        private void buttonDeleteCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                string character = (string) listViewCharacter.SelectedItems[0].Tag;
                DialogResult result = MessageBox.Show("Ви впевнені, що бажаєте видалити цю рису характеру?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _prisoner.Character.Remove(character);
                    UpdateCharacterList(_prisoner);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Спочатку треба вибрати рису характеру");
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (_prisoner != null)
            {
                _prisoner.Name = textBoxName.Text;
                _prisoner.Surname = textBoxSurname.Text;
                _prisoner.Patronymic = textBoxPatronymic.Text;

                try
                {
                    string[] birth = textBoxBirth.Text.Split('.');
                    _prisoner.BirthDate = new DateTime(Int32.Parse(birth[2]), Int32.Parse(birth[1]), Int32.Parse(birth[0]));
                    
                    string[] guard = textBoxStateGuardDate.Text.Split('.');
                    _prisoner.State.GuardDate = new DateTime(Int32.Parse(guard[2]), Int32.Parse(guard[1]), Int32.Parse(guard[0]));
                    
                    if (Global.Codex.ContainsKey(textBoxStateNumber.Text))
                    {
                        _prisoner.State.Number = textBoxStateNumber.Text;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                    _prisoner.State.Length.Years = Int32.Parse(textBoxYears.Text);
                    _prisoner.State.Length.Months = Int32.Parse(textBoxMonths.Text);
                    _prisoner.State.Length.Days = Int32.Parse(textBoxDays.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Введен невірний аргумент");
                }

                textBoxAge.Text = _prisoner.Age.ToString();
                textBoxStateText.Text = _prisoner.State.Text;
                textBoxStateReleaseDate.Text = _prisoner.State.ReleaseDate.ToShortDateString();
                UpdateListView(Global.Prison.Prisoners);
            }
            else
            {
                MessageBox.Show("Спочатку треба вибрати в'язня");
            }
        }
    }
}