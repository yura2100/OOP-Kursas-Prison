using System;

namespace WindowsFormsApp1
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age => (int)((DateTime.Today - BirthDate).TotalDays / 365.2425);

        protected Person(string name, string surname, string patronymic, int year, int month, int day)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDate = new DateTime(year, month, day);
        }
        
        protected Person(){}
    }
}