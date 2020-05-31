using System;

namespace WindowsFormsApp1.Model
{
    //Клас людини
    public abstract class Person
    {
        //Ім'я
        public string Name { get; set; }
        //Прізвище
        public string Surname { get; set; }
        //По-батькові
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