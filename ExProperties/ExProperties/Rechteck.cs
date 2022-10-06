using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProperties
{
    public class Rechteck
    {
        private int laenge, breite;
        

        public int Laenge
        {
            get { return laenge; }
            set { laenge = value >= 0 ? value : throw new ArgumentException("Ungültige Laenge!"); }
        }
        public int Breite
        {
            get { return breite; }
            set { breite = value >= 0 ? value : throw new ArgumentException("Ungültige Breite!"); }
        }

        public int Flaeche
        {
            get { return Laenge * Breite; }
        }

    }
}
