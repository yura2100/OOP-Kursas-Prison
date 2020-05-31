using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.Model
{
    //Клас в'язниці
    [Serializable]
    public class Prison
    {
        //Пароль для авторизації
        public string Password { get; set; }
        //Список в'язнів
        public List<Prisoner> Prisoners;
        //Список камер
        public List<Room> Rooms;
        //Максимальна кількість в'язнів
        public int MaxPrisoners => Rooms.Aggregate(0, (a, room) => a + room.Max);

        public Prison()
        {
            Prisoners = new List<Prisoner>();
            Rooms = new List<Room>();
        }

        //Додавання нового в'язня
        public void Add(string name, string surname, string patronymic, DateTime birth, string stateNumber, DateTime guardDate, int years, int months, int days)
        {
            if (Prisoners.Count < MaxPrisoners)
            {
                var prisoner = new Prisoner(name, surname, patronymic, Prisoners.Count);
                prisoner.BirthDate = birth;
                prisoner.State = new State(stateNumber, guardDate, years, months, days);
                var tempRoom = Rooms.First(r => r.Free != 0);
                prisoner.RoomNumber = tempRoom.Number;
                tempRoom.Free--;
                Prisoners.Add(prisoner);
            }
        }

        //Видалення в'язня
        public void Remove(int id)
        {
            var tempRoom = Rooms.Find(r => r.Number == Prisoners[id].RoomNumber);
            tempRoom.Free++;
            Prisoners.RemoveAt(id);

            for (int i = 0; i < Prisoners.Count; i++)
            {
                Prisoners[i].ID = i;
            }
        }

        //Пошук в'язня за ID
        public List<Prisoner> FindByID(string id)
        {
            int idInt;
            bool success = Int32.TryParse(id, out idInt);
            if (success)
                return Prisoners.FindAll(p => p.ID == idInt);
            else
                throw new ArgumentException();
        }

        //Пошук в'язня за номером статті
        public List<Prisoner> FindByStateNumber(string number)
        {
            return Prisoners.FindAll(p => p.State.Number == number);
        }

        //Пошук в'язня за номером камери
        public List<Prisoner> FindByRoomNumber(string number)
        {
            int numberInt;
            bool success = Int32.TryParse(number, out numberInt);
            if (success)
                return Prisoners.FindAll(p => p.RoomNumber == numberInt);
            else
                throw new ArgumentException();
        }

        //Пошук в'язня за ПІП
        public List<Prisoner> FindByName(string name)
        {
            return Prisoners.FindAll(p =>
            {
                string SFP =  p.Surname + " " + p.Name + " " + p.Patronymic;
                return SFP == name;
            });
        }
        
        //Зміна камери
        public void ChangeRoom(Prisoner prisoner, int n)
        {
            var currentRoom = Rooms.Find(r => r.Number == prisoner.RoomNumber);
            currentRoom.Free++;
            var tempRoom = Rooms.Find(r => r.Number == n);
            prisoner.RoomNumber = tempRoom.Number;
            tempRoom.Free--;
        }

        //Завантаження даних
        public void Load()
        {
            new Dao().Load();
        }

        //Сбереження даних
        public void Save()
        {
            new Dao().Save();
        }

        //Підрахунок статистики
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