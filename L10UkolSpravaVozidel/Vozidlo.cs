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
    }
}
