using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Prisoner : Person
    {
        public int ID { get; set; }
        public List<Relative> Relatives;
        public List<string> Character;
        public State State;
        public Room Room;
        
        public Prisoner(){}
        
        public Prisoner(string name, string surname, string patronymic, int year, int month, int day, int id) :
            base(name, surname, patronymic, year, month, day)
        {
            ID = id;
            Relatives = new List<Relative>();
            Character = new List<string>();
        }
    }
}