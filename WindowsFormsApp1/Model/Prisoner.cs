using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Model
{
    //Клас в'язня
    [Serializable]
    public class Prisoner : Person
    {
        public int ID { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age => (int)((DateTime.Today - BirthDate).TotalDays / 365.2425);
        public List<Relative> Relatives;
        public List<string> Character;
        public State State;
        public Room Room;
        
        public Prisoner(){}
        
        public Prisoner(string name, string surname, string patronymic, int id) :
            base(name, surname, patronymic)
        {
            ID = id;
            Relatives = new List<Relative>();
            Character = new List<string>();
        }
    }
}