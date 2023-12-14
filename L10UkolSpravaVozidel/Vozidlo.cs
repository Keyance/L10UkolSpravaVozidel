using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10UkolSpravaVozidel
{
    public class Vozidlo
    {
        protected string TypVozidla;
        protected string RokVyroby;
        protected string Barva;

        protected int hmotnost;
        public int Hmotnost
        {
            get { return hmotnost; } set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nesprávný input.");
                } else
                {
                hmotnost = value;
                }
            }
        }

        public Vozidlo(string typVozidla, string rokVyroby, string barva)
        {
            TypVozidla = typVozidla;
            RokVyroby = rokVyroby;
            Barva = barva;
        }

        public override string ToString()
        {
            string text = $"{TypVozidla}\t{RokVyroby}\t{Barva}";
            return text;
        }
        public enum Velikost
        {
            Maly,
            Velky
        }
    }
}
