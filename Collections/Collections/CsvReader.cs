using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Collections
{
    class CsvReader
    {
        private string _csvFilePath;

        //CsvReader mano sukurta klasė

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        // Metodas nuskaitantis duomenis ir sudedantis i masyva
        // Countri paties sukurta klase, o sis metodas grazina masyva priimdamas tam tikra kieki saliu

        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                // read header line
                sr.ReadLine();

                for (int i = 0; i < nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }
            return countries;
        }

        // Sukurus masyva issitruakti kiekviena Masyvo ELEMENTA, sukuriant objekta

        public Country ReadCountryFromCsvLine (string csvLine)
        {
            string [] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);

        }
    }
}
