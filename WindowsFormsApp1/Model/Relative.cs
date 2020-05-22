using System;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Relative : Person
    {
        public string Relation { get; set; }

        public Relative(string name, string surname, string patronymic, string relation, int year, int month, int day) : 
            base(name, surname, patronymic, year, month, day)
        {
            Relation = relation;
        }
        
        public Relative(){}
    }
}