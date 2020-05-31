using System;

namespace WindowsFormsApp1.Model
{
    //Клас довжини тюремного сроку
    [Serializable]
    public class Length
    {
        //Кількість років
        public int Years { get; set; }
        //Кількість місяців
        public int Months { get; set; }
        //Кількість днів
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