using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMasinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Masina Audi = new Masina("Audi A6", 1995, "AUD");
            Masina BMW = new Masina("BMW 320", 2006, "BMW");
            


            Dictionary<string, Masina> sarasas = new Dictionary<string, Masina>();
            sarasas.Add(Audi.Kodas, Audi);
            sarasas.Add(BMW.Kodas, BMW);
            


            foreach (var item in sarasas.Values)
            {
                Console.WriteLine(item.Pavadinimas);
            }

            Console.WriteLine("Ko ieskote?");

            Masina suradau = sarasas[Console.ReadLine()];
            Console.WriteLine(suradau.Metai);


            bool exists = sarasas.TryGetValue("AUD", out Masina value);

            Console.WriteLine(exists);
            Console.ReadLine();



        }
    }
}
