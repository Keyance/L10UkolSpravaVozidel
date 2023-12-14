using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10UkolSpravaVozidel
{
    public class SpravceVozidel
    {
        private List<Vozidlo> vozidla = new List<Vozidlo>();

        public void PridejAuto(string typVozidla, string rokVyroby, string barva, int pocetDveri, string model, int hmotnost)
        {
            Automobil automobil = new Automobil(typVozidla, rokVyroby, barva, pocetDveri, model, hmotnost);
            vozidla.Add(automobil);
        }

        public void PridejMotorku(string typVozidla, string rokVyroby, string barva, string typMotocyklu, int pocetKol, int hmotnost)
        {
            Motocykl motocykl = new Motocykl(typVozidla, rokVyroby, barva, typMotocyklu, pocetKol, hmotnost);
            vozidla.Add(motocykl);
        }

        public void VypisVozidla()
        {
            int x = 0;
            foreach (var item in vozidla)
            {
                Console.WriteLine(x + ": " + item);
                x++;
            }
        }

        public Vozidlo VratVozidlo (int index)
        {
            return vozidla[index];
        }

        public void SmazVozidlo(Vozidlo vozidlo)
        {
            vozidla.Remove(vozidlo);
        }

        public void SmazVsechnaVozidla()
        {
            vozidla.Clear();
        }
    }
}
