using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10UkolSpravaVozidel
{
    public class Motocykl : Vozidlo
    {
        private string TypMotocyklu;
        private int PocetKol;

        public Motocykl(string typVozidla, string rokVyroby, string barva, string typMotocyklu, int pocetKol) : base(typVozidla, rokVyroby, barva)
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
