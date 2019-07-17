﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Country
    {
        // Name, Code, Region... sugalvoti paties
        // sukursim objekta is duomenu 4 properciu

        public string Name { get; }
        public string Code { get; }
        public string Region { get; }
        public int Population { get; }

        public Country(string name, string code, string region, int population)
        {
            this.Name = name;
            this.Code = code;
            this.Region = region;
            this.Population = population;

        }
    }
}
