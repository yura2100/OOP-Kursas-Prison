using System;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class State
    {
        public string Number { get; set; }
        public string Text => Global.Codex[Number];
        public DateTime GuardDate { get; set; }
        public Length Length;

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