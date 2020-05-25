using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Prison
    {
        public List<Prisoner> Prisoners;
        public List<Room> Rooms;
        public int MaxPrisoners => Rooms.Aggregate(0, (a, room) => a + room.Max);

        public Prison()
        {
            Prisoners = new List<Prisoner>();
            Rooms = new List<Room>();
        }

        public void Add(string name, string surname, string patronymic, int year, int month, int day)
        {
            if (Prisoners.Count + 1 < MaxPrisoners)
            {
                var prisoner = new Prisoner(name, surname, patronymic, Prisoners.Count);
                var tempRoom = Rooms.First(r => r.Free != 0);
                tempRoom.Free--;
                prisoner.Room = tempRoom;
                Prisoners.Add(prisoner);
            }
        }

        public void Remove(int id)
        {
            Prisoners[id].Room.Free++;
            Prisoners.RemoveAt(id);

            for (int i = 0; i < Prisoners.Count; i++)
            {
                Prisoners[i].ID = i;
            }
        }

        public List<Prisoner> FindByID(string id)
        {
            int idInt;
            bool success = Int32.TryParse(id, out idInt);
            if (success)
                return Prisoners.FindAll(p => p.ID == idInt);
            else
                throw new ArgumentException();
        }

        public List<Prisoner> FindByStateNumber(string number)
        {
            return Prisoners.FindAll(p => p.State.Number == number);
        }

        public List<Prisoner> FindByRoomNumber(string number)
        {
            int numberInt;
            bool success = Int32.TryParse(number, out numberInt);
            if (success)
                return Prisoners.FindAll(p => p.Room.Number == numberInt);
            else
                throw new ArgumentException();
        }

        public List<Prisoner> FindByName(string name)
        {
            return Prisoners.FindAll(p =>
            {
                string SFP =  p.Surname + " " + p.Name + " " + p.Patronymic;
                return SFP == name;
            });
        }

        public void Load()
        {
            new Dao().Load();
        }

        public void Save()
        {
            new Dao().Save();
        }

        public Stats DoStatistics()
        {
            Stats stats = new Stats();
            foreach (var prisoner in Prisoners)
            {
                string state = prisoner.State.Number;
                int age = prisoner.Age;

                if (stats.State.ContainsKey(state))
                    stats.State[state]++;
                else
                    stats.State.Add(state, 1);

                if (stats.Age.ContainsKey(age))
                    stats.Age[age]++;
                else
                    stats.Age.Add(age, 1);

                stats.AverageAge += age;
            }
            stats.AverageAge /= Prisoners.Count;

            stats.MaxState = stats.State.First(x => x.Value == stats.State.Values.Max()).Key;
            stats.MaxAge = stats.Age.First(x => x.Value == stats.Age.Values.Max()).Key;
            
            foreach (var age in stats.Age.Keys)
            {
                if (stats.Age[age] > stats.Age[stats.MaxAge]) stats.MaxAge = age;
            }
            
            return stats;
        }
    }
}