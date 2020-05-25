using System.Collections.Generic;

namespace WindowsFormsApp1.Model
{
    public class Stats
    {
        public Dictionary<string, int> State = new Dictionary<string, int>();
        public Dictionary<int, int> Age = new Dictionary<int, int>();
        public string MaxState;
        public int MaxAge;
        public int AverageAge = 0;
        
        public Stats() { }
    }
}