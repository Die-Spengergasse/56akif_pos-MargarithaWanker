using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProperties
{
    public class Lehrer
    {
        private string  vorname, zuname;
        private decimal? bruttogehalt;

        public string Vorname { get; set; } = "";
        public string? Zuname { get; set; }

        public decimal? Bruttogehalt
        {
            get { return bruttogehalt; }
            set { bruttogehalt ??= value; }
        }

        public string? Kuerzel
        {
            get { return Zuname?.ToUpper().Substring(0, 3) ?? ""; }
        }

        public decimal Nettogehalt
        {
            get { return (Bruttogehalt * 0.8M) ?? 0M; }
        }
    }
}
