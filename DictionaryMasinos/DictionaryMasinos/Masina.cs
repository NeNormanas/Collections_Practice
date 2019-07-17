using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMasinos
{
    class Masina
    {
        public string Pavadinimas { get; }
        public int Metai { get; }
        public string Kodas { get; }

        public Masina(string pavadinimas, int metai, string kodas)
        {
            this.Pavadinimas = pavadinimas;
            this.Metai = metai;
            this.Kodas = kodas;

       
        }

    }
}
