﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    //Основна форма для персоналу
    public partial class Main : Menu
    {
        public Main()
        {
            InitializeComponent();
        }

        //Обробка події натискання на кнопку "Шукати"
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

        //Обробка події показу форми
        private void Main_Shown(object sender, EventArgs e)
        {
            UpdateListView(Global.Prison.Prisoners);
        }

        //Метод оновлення відображення даних у списку в'язнів
        public void UpdateListView(List<Prisoner> list)
        {
            listView1.Items.Clear();
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());
                lvi.SubItems.Add($"{item.Surname} {item.Name} {item.Patronymic}");
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }
        
        //Метод оновлення відображення даних у списку родичів
        public void UpdateRelativesList(Prisoner prisoner)
        {
            listViewRelatives.Items.Clear();
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

        //Метод оновлення відображення даних у списку рис характеру
        public void UpdateCharacterList(Prisoner prisoner)
        {
            listViewCharacter.Items.Clear();
            foreach (var character in prisoner.Character)
            {
                ListViewItem lvi = new ListViewItem(character);
                lvi.Tag = character;
                listViewCharacter.Items.Add(lvi);
            }
        }
        
        //Обробка події натискання на елемент зі списку в'язнів
        protected virtual void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            Prisoner prisoner = (Prisoner) listView1.SelectedItems[0].Tag;
            textBoxName.Text = prisoner.Name;
            textBoxSurname.Text = prisoner.Surname;
            textBoxPatronymic.Text = prisoner.Patronymic;
            textBoxAge.Text = prisoner.Age.ToString();
            textBoxBirth.Text = prisoner.BirthDate.ToShortDateString();
            textBoxID.Text = prisoner.ID.ToString();

            var tempRoom = Global.Prison.Rooms.Find(r => r.Number == prisoner.RoomNumber);
            textBoxRoomNumber.Text = tempRoom.Number.ToString();
            textBoxRoomMax.Text = tempRoom.Max.ToString();
            textBoxRoomFree.Text = tempRoom.Free.ToString();
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
