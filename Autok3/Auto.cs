using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autok3
{
    internal class Auto
    {
        
        string rendszam;
        string marka;
        string modell;
        int gyartasiev; //year - int
        DateTime forgalmiErvenyesseg;    //date Date Time
        int vetelar;
        int kmallas;
        int hengerurtartalom;
        int tomeg;
        int teljesitmeny;
        public Auto() { }

        public Auto(string rendszam, string marka, string modell, int gyartasiev, DateTime forgalmiErvenyesseg, int vetelar, int kmallas, int hengerurtartalom, int tomeg, int teljesitmeny)
        {
            
            this.rendszam = rendszam;
            this.marka = marka;
            this.modell = modell;
            this.gyartasiev = gyartasiev;
            this.forgalmiErvenyesseg = forgalmiErvenyesseg;
            this.vetelar = vetelar;
            this.kmallas = kmallas;
            this.hengerurtartalom = hengerurtartalom;
            this.tomeg = tomeg;
            this.teljesitmeny = teljesitmeny;
        }

        
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Gyartasiev { get => gyartasiev; set => gyartasiev = value; }
        public DateTime ForgalmiErvenyesseg { get => forgalmiErvenyesseg; set => forgalmiErvenyesseg = value; }
        public int Vetelar { get => vetelar; set => vetelar = value; }
        public int Kmallas { get => kmallas; set => kmallas = value; }
        public int Hengerurtartalom { get => hengerurtartalom; set => hengerurtartalom = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }

        public override string ToString()
        {
            return $"{this.marka} - {this.modell}";
        }

    }

}
