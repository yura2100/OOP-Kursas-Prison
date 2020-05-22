using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Prison
    {
        public int CurentPrisoner { get; set; }
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
            if (CurentPrisoner < MaxPrisoners)
            {
                var prisoner = new Prisoner(name, surname, patronymic, year, month, day, CurentPrisoner);
                var tempRoom = Rooms.First(r => r.Free != 0);
                tempRoom.Free--;
                prisoner.Room = tempRoom;
                Prisoners.Insert(CurentPrisoner, prisoner);
                CurentPrisoner++;
            }
        }

        public void Remove(int id)
        {
            Prisoners.RemoveAt(id);
            CurentPrisoner = id;
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
    }
}