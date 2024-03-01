using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok3
{
    internal static class Program
    {
        public static List<Auto> autok = new List<Auto>();
        public static FormMain formMain = null;  
        public static Adatbazis adatbazis = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            adatbazis = new Adatbazis(); 
            autok = adatbazis.getAllAuto();
            formMain = new FormMain();
            
            Application.Run(formMain);
        }
    }
}
