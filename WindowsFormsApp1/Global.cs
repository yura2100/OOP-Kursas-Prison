using System.Collections.Generic;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    //Глобальний стан програми
    public static class Global
    {
        //Об'єкт в'язниці
        public static Prison Prison = new Prison();
        //Словник кримінального кодексу України
        public static Dictionary<string, string> Codex = new Dictionary<string, string>();
        //Головна форма
        public static Main Main;
        //Форма статистики
        public static Statistics Statistics = new Statistics();
    }
}