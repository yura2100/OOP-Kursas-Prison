using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class Main : Menu
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                List<Prisoner> result = Global.Prison.Prisoners;
                if (input != "Пошук")
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            result = Global.Prison.FindByID(input);
                            break;
                        case 1:
                            result = Global.Prison.FindByName(input);
                            break;
                        case 2:
                            result = Global.Prison.FindByStateNumber(input);
                            break;
                        case 3:
                            result = Global.Prison.FindByRoomNumber(input);
                            break;
                    }
                }

                UpdateListView(result);
                listView1.Focus();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Аргументом для пошуку можуть бути лише цілі числа");
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            UpdateListView(Global.Prison.Prisoners);
        }

        public void UpdateListView(List<Prisoner> list)
        {
            foreach (var item in listView1.Items)
            {
                listView1.Items.Remove((ListViewItem)item);
            }
            
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());
                lvi.SubItems.Add($"{item.Surname} {item.Name} {item.Patronymic}");
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }
        
        public void UpdateRelativesList(Prisoner prisoner)
        {
            foreach (var item in listViewRelatives.Items)
            {
                listViewRelatives.Items.Remove((ListViewItem)item);
            }
            
            foreach (var relative in prisoner.Relatives)
            {
                ListViewItem lvi = new ListViewItem(relative.Name);
                lvi.SubItems.Add(relative.Surname);
                lvi.SubItems.Add(relative.Patronymic);
                lvi.SubItems.Add(relative.Relation);
                lvi.Tag = relative;
                listViewRelatives.Items.Add(lvi);
            }
        }

        public void UpdateCharacterList(Prisoner prisoner)
        {
            foreach (var item in listViewCharacter.Items)
            {
                listViewCharacter.Items.Remove((ListViewItem)item);
            }
            
            foreach (var character in prisoner.Character)
            {
                ListViewItem lvi = new ListViewItem(character);
                lvi.Tag = character;
                listViewCharacter.Items.Add(lvi);
            }
        }
        
        protected virtual void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            Prisoner prisoner = (Prisoner) listView1.SelectedItems[0].Tag;
            textBoxName.Text = prisoner.Name;
            textBoxSurname.Text = prisoner.Surname;
            textBoxPatronymic.Text = prisoner.Patronymic;
            textBoxAge.Text = prisoner.Age.ToString();
            textBoxBirth.Text = prisoner.BirthDate.ToShortDateString();
            textBoxID.Text = prisoner.ID.ToString();
            textBoxRoomNumber.Text = prisoner.Room.Number.ToString();
            textBoxRoomMax.Text = prisoner.Room.Max.ToString();
            textBoxRoomFree.Text = prisoner.Room.Free.ToString();
            textBoxStateNumber.Text = prisoner.State.Number;
            textBoxStateGuardDate.Text = prisoner.State.GuardDate.ToShortDateString();
            textBoxStateReleaseDate.Text = prisoner.State.ReleaseDate.ToShortDateString();
            textBoxYears.Text = prisoner.State.Length.Years.ToString();
            textBoxMonths.Text = prisoner.State.Length.Months.ToString();
            textBoxDays.Text = prisoner.State.Length.Days.ToString();
            textBoxStateText.Text = prisoner.State.Text;
            UpdateRelativesList(prisoner);
            UpdateCharacterList(prisoner);
        }
    }
}
