using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    //Форма статистики
    public partial class Statistics : Menu
    {
        public Statistics()
        {
            InitializeComponent();
        }
        
        //Обробка події зміни видимості
        private void Statistics_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                var stats = Global.Prison.DoStatistics();
                
                //Стаття
                listViewState.Items.Clear();
            
                foreach (var item in stats.State.Keys)
                {
                    ListViewItem lvi = new ListViewItem(item);
                    lvi.SubItems.Add($"{stats.State[item]}");
                    listViewState.Items.Add(lvi);
                }

                textBoxMaxState.Text = stats.MaxState;
                
                //Вік
                listViewAge.Items.Clear();
            
                foreach (var item in stats.Age.Keys)
                {
                    ListViewItem lvi = new ListViewItem(item.ToString());
                    lvi.SubItems.Add($"{stats.Age[item]}");
                    listViewAge.Items.Add(lvi);
                }

                textBoxMaxAge.Text = stats.MaxAge.ToString();
                textBoxAverageAge.Text = stats.AverageAge.ToString();
            }
        }
    }
}