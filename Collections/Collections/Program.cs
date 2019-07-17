using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // failo  kelias is kur imsiu duomenis.
            string filePath = @"C:\Users\Normanas\Downloads\csharp-collections-beginning\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine(country.Population + " " + country.Name);
            }
            Console.ReadLine();
        }
    }
}