using System.Collections.Generic;

namespace WindowsFormsApp1.Model
{
    //Клас статистики
    public class Stats
    {
        //Словник для статті
        public Dictionary<string, int> State = new Dictionary<string, int>();
        //Словник для віку
        public Dictionary<int, int> Age = new Dictionary<int, int>();
        //Мода статтей
        public string MaxState;
        //Мода віків
        public int MaxAge;
        //Середній вік
        public int AverageAge = 0;
        
        public Stats() { }
    }
}