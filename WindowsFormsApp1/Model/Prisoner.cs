using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Model
{
    //Клас в'язня
    [Serializable]
    public class Prisoner : Person
    {
        //ID
        public int ID { get; set; }
        //Дата народження
        public DateTime BirthDate { get; set; }
        //Вік
        public int Age => (int)((DateTime.Today - BirthDate).TotalDays / 365.2425);
        //Список родичів
        public List<Relative> Relatives;
        //Список рис характеру
        public List<string> Character;
        //Стаття
        public State State;
        //Номер камери
        public int RoomNumber;
        
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