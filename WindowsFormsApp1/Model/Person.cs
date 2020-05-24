using System;

namespace WindowsFormsApp1.Model
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        protected Person(string name, string surname, string patronymic)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }
        
        protected Person(){}
    }
}