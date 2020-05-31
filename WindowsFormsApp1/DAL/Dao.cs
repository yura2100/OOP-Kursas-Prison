using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DAL
{
    //Клас доступу до даних
    class Dao
    {
        //Шлях до файлу з в'язницею
        private const string pathPrison = "Prison.xml";
        //Шлях до файлу з паролем
        private const string pathPassword = "Password.txt";
        //Шдях до кримінального кодексу України
        private const string pathCodex = "Codex.txt";
        
        //Завантаження даних
        public void Load()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Prison));
            
            using (FileStream fs = new FileStream(pathPrison, FileMode.OpenOrCreate))
            {
                Global.Prison = (Prison)xml.Deserialize(fs);
            }
            
            TextReader readerPassword = new StreamReader(pathPassword, Encoding.Default);
            Global.Prison.Password = readerPassword.ReadToEnd();
            readerPassword.Close();
            
            TextReader readerCodex = new StreamReader(pathCodex, Encoding.Default);
            string[] arr = readerCodex.ReadToEnd().Split('\n');
            readerCodex.Close();
            
            foreach (var item in arr)
            {
                string[] elements = item.Split(':');
                Global.Codex.Add(elements[0], elements[1]);
            }
        }
        
        //Збереження даних
        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Prison));
            
            using(FileStream fs = new FileStream(pathPrison, FileMode.Create))
            {
                xml.Serialize(fs, Global.Prison);
            }
        }
    }
}
