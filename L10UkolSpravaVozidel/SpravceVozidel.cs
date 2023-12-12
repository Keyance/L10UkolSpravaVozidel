using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10UkolSpravaVozidel
{
    public class SpravceVozidel
    {
        List<Vozidlo> vozidla = new List<Vozidlo>();

        public void PridejAuto(string typVozidla, string rokVyroby, string barva, int pocetDveri, string model)
        {
            Automobil automobil = new Automobil(typVozidla, rokVyroby, barva, pocetDveri, model);
            vozidla.Add(automobil);
        }

        public void PridejMotorku(string typVozidla, string rokVyroby, string barva, string typMotocyklu, int pocetKol)
        {
            Motocykl motocykl = new Motocykl(typVozidla, rokVyroby, barva, typMotocyklu, pocetKol);
            vozidla.Add(motocykl);
        }

        public void VypisVozidla()
        {
            foreach (var item in vozidla)
            {
                Console.WriteLine(item);
            }
        }
    }
}
