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
    class Dao
    {
        const string pathPrison = "Prison.xml";
        const string pathCodex = "Codex.txt";

        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Prison));
            
            using(FileStream fs = new FileStream(pathPrison, FileMode.Create))
            {
                xml.Serialize(fs, Global.Prison);
            }
        }

        public void Load()
        {
            TextReader reader = new StreamReader(pathCodex, Encoding.Default);
            string[] arr = reader.ReadToEnd().Split('\n');
            reader.Close();
            
            foreach (var item in arr)
            {
                string[] elements = item.Split(':');
                Global.Codex.Add(elements[0], elements[1]);
            }
            
            XmlSerializer xml = new XmlSerializer(typeof(Prison));
            
            using (FileStream fs = new FileStream(pathPrison, FileMode.OpenOrCreate))
            {
                Global.Prison = (Prison)xml.Deserialize(fs);
            }
        }
    }
}
