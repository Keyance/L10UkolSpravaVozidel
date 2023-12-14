using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10UkolSpravaVozidel
{
    public class Automobil : Vozidlo
    {
        private int PocetDveri;
        private string Model;

        private Velikost velikostAuta;
        public Velikost VelikostAuta
        {
            get { return velikostAuta; }
            set
            {
                if (Hmotnost < 400)
                {
                    velikostAuta = Velikost.Maly;
                } else { velikostAuta = Velikost.Velky; }
            }
        }

        public Automobil(string typVozidla, string rokVyroby, string barva, int pocetDveri, string model) : base(typVozidla, rokVyroby, barva)
        {
            PocetDveri = pocetDveri;
            Model = model;
        }

        public override string ToString()
        {
            string puvodni = base.ToString();
            string text = $"\t{Model}\t{PocetDveri}";
            return puvodni + text;

        }
    }
}
