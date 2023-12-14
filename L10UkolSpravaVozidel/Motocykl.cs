using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static L10UkolSpravaVozidel.Automobil;

namespace L10UkolSpravaVozidel
{
    public class Motocykl : Vozidlo
    {
        private string TypMotocyklu;
        private int PocetKol;

        private Velikost velikostMotocyklu;
        public Velikost VelikostMotocyklu
        {
            get { return velikostMotocyklu; }
            set
            {
                if (Hmotnost < 150)
                {
                    velikostMotocyklu = Velikost.Maly;
                }
                else { velikostMotocyklu = Velikost.Velky; }
            }
        }

        public Motocykl(string typVozidla, string rokVyroby, string barva, string typMotocyklu, int pocetKol, int hmotnost) : base(typVozidla, rokVyroby, barva, hmotnost)
        {
            TypMotocyklu = typMotocyklu;
            PocetKol = pocetKol;
        }

        public override string ToString()
        {
            string puvodni =  base.ToString();
            string text = $"\t{TypMotocyklu}\t{PocetKol}";
            return puvodni + text ;

        }
    }
}
