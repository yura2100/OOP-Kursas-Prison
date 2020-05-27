using System;

namespace WindowsFormsApp1.Model
{
    //Клас камери
    [Serializable]
    public class Room
    {
        public int Number;
        public int Max;
        public int Free;
        
        public Room() { }
    }
}