using System;

namespace WindowsFormsApp1.Model
{
    //Клас камери
    [Serializable]
    public class Room
    {
        //Номер камери
        public int Number;
        //Максимальна кількість в'язнів у камері
        public int Max;
        //Кількість вільних місць у камері
        public int Free;
        
        public Room() { }
    }
}