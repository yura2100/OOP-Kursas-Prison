using System;

namespace WindowsFormsApp1.Model
{
    //Клас родича
    [Serializable]
    public class Relative : Person
    {
        public string Relation { get; set; }

        public Relative(string name, string surname, string patronymic, string relation) : 
            base(name, surname, patronymic)
        {
            Relation = relation;
        }
        
        public Relative(){}
    }
}