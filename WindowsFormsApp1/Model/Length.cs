using System;

namespace WindowsFormsApp1.Model
{
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