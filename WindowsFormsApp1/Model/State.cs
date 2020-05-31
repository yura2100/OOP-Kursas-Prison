using System;

namespace WindowsFormsApp1.Model
{
    //Клас сроку
    [Serializable]
    public class State
    {
        //Номер статті
        public string Number { get; set; }
        //Текст статті
        public string Text => Global.Codex[Number];
        //Дата взяття під варту
        public DateTime GuardDate { get; set; }
        //Довжина сроку
        public Length Length;
        //Дата визволення
        public DateTime ReleaseDate
        {
            get
            {
                DateTime releaseDate = new DateTime(GuardDate.Year, GuardDate.Month, GuardDate.Day);
                releaseDate = releaseDate.AddYears(Length.Years);
                releaseDate = releaseDate.AddMonths(Length.Months);
                releaseDate = releaseDate.AddDays(Length.Days);
                return releaseDate;
            }
        }

        public State()
        {
        }

        public State(string number, DateTime guardDate, int years, int months, int days)
        {
            Number = number;
            GuardDate = guardDate;
            Length = new Length(years, months, days);
        }
    }
}