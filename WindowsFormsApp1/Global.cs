using System.Collections.Generic;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public static class Global
    {
        public static Prison Prison = new Prison();
        public static Dictionary<string, string> Codex = new Dictionary<string, string>();
        public static Main Main;
        public static Statistics Statistics= new Statistics();
    }
}