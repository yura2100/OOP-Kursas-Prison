using System;

namespace WindowsFormsApp1
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
        
        public State() { }

        public State(string number, int guardYear, int guardMonth, int guardDay, int years, int months, int days)
        {
            Number = number;
            GuardDate = new DateTime(guardYear, guardMonth, guardDay);
            Length = new Length(years, months, days);
        }
    }
    
    [Serializable]
    public class Length
    {
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }
        
        public Length(){}

        public Length(int years, int months, int days)
        {
            Years = years;
            Months = months;
            Days = days;
        }
    }
}