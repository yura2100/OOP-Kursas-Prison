using System;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    //Основна форма начальника в'язниці
    public partial class MainLord : Main
    {
        private Prisoner _prisoner;
        public MainLord()
        {
            InitializeComponent();
        }
        
        //Обробка події натискання на елемент зі списку в'язнів
        protected override void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            base.listView1_MouseClick(sender, e);
            _prisoner = (Prisoner) listView1.SelectedItems[0].Tag;
            comboBoxRoomNumber.Text = _prisoner.RoomNumber.ToString();
            
            comboBoxRoomNumber.Items.Clear();
            var rooms = Global.Prison.Rooms.FindAll(r => r.Free != 0);
            foreach (var room in rooms)
            {
                comboBoxRoomNumber.Items.Add(room.Number);
            }

            comboBoxStateNumber.Text = _prisoner.State.Number;
            foreach (var state in Global.Codex.Keys)
            {
                comboBoxStateNumber.Items.Add(state);
            }
        }

        //Обробка події натискання на кнопку "Видалити в'язня"
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

        //Обробка події натискання на кнопку "Додати родича"
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

        //Обробка події натискання на кнопку "Видалити родича"
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
        
        //Обробка події натискання на кнопку "Додати рису характеру"
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

        //Обробка події натискання на кнопку "Видалити рису характеру"
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

        //Обробка події натискання на кнопку "Внести зміни"
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
                    
                    if (Global.Codex.ContainsKey(comboBoxStateNumber.Text))
                    {
                        _prisoner.State.Number = comboBoxStateNumber.Text;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                    _prisoner.State.Length.Years = Int32.Parse(textBoxYears.Text);
                    _prisoner.State.Length.Months = Int32.Parse(textBoxMonths.Text);
                    _prisoner.State.Length.Days = Int32.Parse(textBoxDays.Text);

                    if (Global.Prison.Rooms.Exists(r => r.Number == Int32.Parse(comboBoxRoomNumber.Text)))
                    {
                        Global.Prison.ChangeRoom(_prisoner, Int32.Parse(comboBoxRoomNumber.Text));
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Введен невірний аргумент");
                }

                textBoxAge.Text = _prisoner.Age.ToString();
                textBoxStateText.Text = _prisoner.State.Text;
                textBoxStateReleaseDate.Text = _prisoner.State.ReleaseDate.ToShortDateString();

                var tempRoom = Global.Prison.Rooms.Find(r => r.Number == _prisoner.RoomNumber);
                textBoxRoomFree.Text = tempRoom.Free.ToString();
                textBoxRoomMax.Text = tempRoom.Max.ToString();
                
                UpdateListView(Global.Prison.Prisoners);
            }
            else
            {
                MessageBox.Show("Спочатку треба вибрати в'язня");
            }
        }

        //Обробка події натискання на кнопку "Додати нового в'язня"
        private void buttonAddPrisoner_Click(object sender, EventArgs e)
        {
            AddPrisoner f = new AddPrisoner();
            f.Show();
        }
    }
}