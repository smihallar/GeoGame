using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyGameTest
{
    class Country
    {
        public Country(string countryName, string capital, List<string> continents, string flagPath)
        {
            CountryName = countryName;
            Capital = capital;
            Continents = continents;
            FlagPath = flagPath;
        }


        public string CountryName { get; set; }
        public string Capital { get; set; }
        public List<string> Continents { get; set; }
        public string FlagPath { get; set; }


    }
}
