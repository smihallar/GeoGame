using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyGameTest
{
    internal class CountryManager
    {
        List<Country> countryList = new List<Country>();
        private const string basePath = @"C:\Users\smill\OneDrive\Programmering\GeographyGameTest\GeographyGameTest\Flags\";
        public void SetUp()
        {
            var countries = GetCountries();

            foreach (var country in countries)
            {

                string imagePath = Path.Join(basePath, country.ImagePath);
                if (!File.Exists(imagePath))
                {
                    throw new FileNotFoundException($"Image file not found: {imagePath}");
                }
                countryList.Add(new Country(country.Name, country.Capital, country.Continents, imagePath));
            }
        }
        private List<(string Name, string Capital, List<string> Continents, string ImagePath)> GetCountries()
        {
            return new List<(string Name, string Capital, List<string> Continents, string ImagePath)>
            {
                ("Canada", "Ottawa", new List<string> { "North America" }, "Canada.png"),
                    ("The United States of America", "Washington", new List<string> { "North America" }, "US.png"),
                    ("Mexico", "Mexico City", new List<string> { "North America" }, "Mexico.png"),
                    ("Guatemala", "Guatemala City", new List<string> { "North America" }, "Guatemala.png"),
                    ("Belize", "Belmopan", new List<string> { "North America" }, "Belize.png"),
                    ("Nicaragua", "Managua", new List<string> { "North America" }, "Nicaragua.png"),
                    ("Honduras", "Tegucigalpa", new List<string> { "North America" }, "Honduras.png"),
                    ("El Salvador", "San Salvador", new List<string> { "North America" }, "ElSalvador.png"),
                    ("Costa Rica", "San José", new List<string> { "North America" }, "CostaRica.png"),
                    ("Panama", "Panama City", new List<string> { "North America", "South America" }, "Panama.png"),
                    ("Cuba", "Havana", new List<string> { "North America" }, "Cuba.png"),
                    ("Jamaica", "Kingston", new List<string> { "North America" }, "Jamaica.png"),
                    ("Haiti", "Port-au-prince", new List<string> { "North America" }, "Haiti.png"),
                    ("Dominican Republic", "Santo Domingo", new List<string> { "North America" }, "DominicanRepublic.png"),
                    ("Bahamas", "Nassau", new List<string> { "North America" }, "Bahamas.png"),
                    ("Saint Kitts and Nevis", "Basseterre", new List<string> { "North America" }, "StKittsAndNevis.png"),
                    ("Antigua and Barbuda", "Saint John's", new List<string> { "North America" }, "AntiguaAndBarbuda.png"),
                    ("Dominica", "Roseau", new List<string> { "North America" }, "Dominica.png"),
                    ("Barbados", "Bridgetown", new List<string> { "North America" }, "Barbados.png"),
                    ("Saint Lucia", "Castries", new List<string> { "North America" }, "StLucia.png"),
                    ("Saint Vincent and The Grenadines", "Kingstown", new List<string> { "North America" }, "StVincentAndGrenadines.png"),
                    ("Grenada", "Saint George's", new List<string> { "North America" }, "Grenada.png"),
                    ("Trinidad and Tobago", "Port of Spain", new List<string> { "North America" }, "TrinidadAndTobago.png"),

                    //South America
                    ("Colombia", "Bogotá", new List<string> { "South America" }, "Colombia.png"),
                    ("Argentina", "Buenos Aires", new List<string> { "South America" }, "Argentina.png"),
                    ("Bolivia", "Sucre", new List<string> { "South America" }, "Bolivia.png"),
                    ("Brazil", "Brasilia", new List<string> { "South America" }, "Brazil.png"),
                    ("Chile", "Santiago", new List<string> { "South America" }, "Chile.png"),
                    ("Ecuador", "Quito", new List<string> { "South America" }, "Ecuador.png"),
                    ("Guyana", "Georgetown", new List<string> { "South America" }, "Guyana.png"),
                    ("Paraguay", "Asunción", new List<string> { "South America" }, "Paraguay.png"),
                    ("Peru", "Lima", new List<string> { "South America" }, "Peru.png"),
                    ("Suriname", "Paramaribo", new List<string> { "South America" }, "Suriname.png"),
                    ("Venezuela", "Caracas", new List<string> { "South America" }, "Venezuela.png"),
                    ("Uruguay", "Montevideo", new List<string> { "South America" }, "Uruguay.png"),

                    //Europe
                    ("Sweden", "Stockholm", new List<string> { "Europe" }, "Sweden.png"),
                    ("Norway", "Oslo", new List<string> { "Europe" }, "Norway.png"),
                    ("Finland", "Helsinki", new List<string> { "Europe" }, "Finland.png"),
                    ("Russia", "Moscow", new List<string> { "Europe", "Asia" }, "Russia.png"),
                    ("Germany", "Berlin", new List<string> { "Europe" }, "Germany.png"),
                    ("United Kingdom", "London", new List<string> { "Europe" }, "UK.png"),
                    ("France", "Paris", new List<string> { "Europe" }, "France.png"),
                    ("Italy", "Rome", new List<string> { "Europe" }, "Italy.png"),
                    ("Spain", "Madrid", new List<string> { "Europe" }, "Spain.png"),
                    ("Poland", "Warsaw", new List<string> { "Europe" }, "Poland.png"),
                    ("Ukraine", "Kyiv", new List<string> { "Europe" }, "Ukraine.png"),
                    ("Romania", "Bucharest", new List<string> { "Europe" }, "Romania.png"),
                    ("Netherlands", "Amsterdam", new List<string> { "Europe" }, "Netherlands.png"),
                    ("Belgium", "Brussels", new List<string> { "Europe" }, "Belgium.png"),
                    ("Czechia", "Prague", new List<string> { "Europe" }, "Czechia.png"),
                    ("Portugal", "Lisbon", new List<string> { "Europe" }, "Portugal.png"),
                    ("Greece", "Athens", new List<string> { "Europe" }, "Greece.png"),
                    ("Hungary", "Budapest", new List<string> { "Europe" }, "Hungary.png"),
                    ("Austria", "Vienna", new List<string> { "Europe" }, "Austria.png"),
                    ("Belarus", "Minsk", new List<string> { "Europe" }, "Belarus.png"),
                    ("Switzerland", "Bern", new List<string> { "Europe" }, "Switzerland.png"),
                    ("Bulgaria", "Sofia", new List<string> { "Europe" }, "Bulgaria.png"),
                    ("Serbia", "Belgrade", new List<string> { "Europe" }, "Serbia.png"),
                    ("Denmark", "Copenhagen", new List<string> { "Europe" }, "Denmark.png"),
                    ("Slovakia", "Bratislava", new List<string> { "Europe" }, "Slovakia.png"),
                    ("Ireland", "Dublin", new List<string> { "Europe" }, "Ireland.png"),
                    ("Croatia", "Zagreb", new List<string> { "Europe" }, "Croatia.png"),
                    ("Bosnia and Herzegovina", "Sarajevo", new List<string> { "Europe" }, "BosniaAndHerzegovina.png"),
                    ("Moldova", "Chisinau", new List<string> { "Europe" }, "Moldova.png"),
                    ("Lithuania", "Vilnius", new List<string> { "Europe" }, "Lithuania.png"),
                    ("Albania", "Tirana", new List<string> { "Europe" }, "Albania.png"),
                    ("Slovenia", "Ljubljana", new List<string> { "Europe" }, "Slovenia.png"),
                    ("Latvia", "Riga", new List<string> { "Europe" }, "Latvia.png"),
                    ("North Macedonia", "Skopje", new List<string> { "Europe" }, "NorthMacedonia.png"),
                    ("Estonia", "Tallinn", new List<string> { "Europe" }, "Estonia.png"),
                    ("Luxembourg", "Luxembourg", new List<string> { "Europe" }, "Luxembourg.png"),
                    ("Montenegro", "Podgorica", new List<string> { "Europe" }, "Montenegro.png"),
                    ("Malta", "Valletta", new List<string> { "Europe" }, "Malta.png"),
                    ("Iceland", "Reykjavik", new List<string> { "Europe" }, "Iceland.png"),
                    ("Andorra", "Andorra la Vella", new List<string> { "Europe" }, "Andorra.png"),
                    ("Liechtenstein", "Vaduz", new List<string> { "Europe" }, "Liechtenstein.png"),
                    ("Monaco", "Monaco", new List<string> { "Europe" }, "Monaco.png"),
                    ("San Marino", "San Marino", new List<string> { "Europe" }, "SanMarino.png"),
                    ("Vatican City", "Vatican City", new List<string> { "Europe" }, "VaticanCity.png"),

                    //Africa
                    ("Nigeria", "Abuja", new List<string> { "Africa" }, "Nigeria.png"),
                    ("Ethiopia", "Addis Ababa", new List<string> { "Africa" }, "Ethiopia.png"),
                    ("Egypt", "Cairo", new List<string> { "Africa", "Asia" }, "Egypt.png"),
                    ("Democratic Republic of the Congo", "Kinshasa", new List<string> { "Africa" }, "DemRepCongo.png"),
                    ("Tanzania", "Dodoma", new List<string> { "Africa" }, "Tanzania.png"),
                    ("South Africa", "Pretoria", new List<string> { "Africa" }, "SouthAfrica.png"),
                    ("Kenya", "Nairobi", new List<string> { "Africa" }, "Kenya.png"),
                    ("Sudan", "Khartoum", new List<string> { "Africa" }, "Sudan.png"),
                    ("Uganda", "Kampala", new List<string> { "Africa" }, "Uganda.png"),
                    ("Algeria", "Algiers", new List<string> { "Africa" }, "Algeria.png"),
                    ("Morocco", "Rabat", new List<string> { "Africa" }, "Morocco.png"),
                    ("Angola", "Luanda", new List<string> { "Africa" }, "Angola.png"),
                    ("Mozambique", "Maputo", new List<string> { "Africa" }, "Mozambique.png"),
                    ("Ghana", "Accra", new List<string> { "Africa" }, "Ghana.png"),
                    ("Madagascar", "Antananarivo", new List<string> { "Africa" }, "Madagascar.png"),
                    ("Cote d'Ivoire", "Yamoussoukro", new List<string> { "Africa" }, "IvoryCoast.png"),
                    ("Cameroon", "Yaounde", new List<string> { "Africa" }, "Cameroon.png"),
                    ("Niger", "Niamey", new List<string> { "Africa" }, "Niger.png"),
                    ("Mali", "Bamako", new List<string> { "Africa" }, "Mali.png"),
                    ("Burkina Faso", "Ouagadougou", new List<string> { "Africa" }, "BurkinaFaso.png"),
                    ("Malawi", "Lilongwe", new List<string> { "Africa" }, "Malawi.png"),
                    ("Zambia", "Lusaka", new List<string> { "Africa" }, "Zambia.png"),
                    ("Chad", "N'Djamena", new List<string> { "Africa" }, "Chad.png"),
                    ("Somalia", "Mogadishu", new List<string> { "Africa" }, "Somalia.png"),
                    ("Senegal", "Dakar", new List<string> { "Africa" }, "Senegal.png"),
                    ("Zimbabwe", "Harare", new List<string> { "Africa" }, "Zimbabwe.png"),
                    ("Guinea", "Conakry", new List<string> { "Africa" }, "Guinea.png"),
                    ("Benin", "Porto-Novo", new List<string> { "Africa" }, "Benin.png"),
                    ("Rwanda", "Kigali", new List<string> { "Africa" }, "Rwanda.png"),
                    ("Burundi", "Gitega", new List<string> { "Africa" }, "Burundi.png"),
                    ("Tunisia", "Tunis", new List<string> { "Africa" }, "Tunisia.png"),
                    ("South Sudan", "Juba", new List<string> { "Africa" }, "SouthSudan.png"),
                    ("Togo", "Lome", new List<string> { "Africa" }, "Togo.png"),
                    ("Sierra Leone", "Freetown", new List<string> { "Africa" }, "SierraLeone.png"),
                    ("Libya", "Tripoli", new List<string> { "Africa" }, "Libya.png"),
                    ("The Republic of the Congo", "Brazzaville", new List<string> { "Africa" }, "RepCongo.png"),
                    ("Liberia", "Monrovia", new List<string> { "Africa" }, "Liberia.png"),
                    ("Central African Republic", "Bangui", new List<string> { "Africa" }, "CAR.png"),
                    ("Mauritania", "Nouakchott", new List<string> { "Africa" }, "Mauritania.png"),
                    ("Eritrea", "Asmara", new List<string> { "Africa" }, "Eritrea.png"),
                    ("Namibia", "Windhoek", new List<string> { "Africa" }, "Namibia.png"),
                    ("Gambia", "Banjul", new List<string> { "Africa" }, "Gambia.png"),
                    ("Gabon", "Libreville", new List<string> { "Africa" }, "Gabon.png"),
                    ("Botswana", "Gaborone", new List<string> { "Africa" }, "Botswana.png"),
                    ("Lesotho", "Maseru", new List<string> { "Africa" }, "Lesotho.png"),
                    ("Guinea-Bissau", "Bissau", new List<string> { "Africa" }, "GuineaBissau.png"),
                    ("Equatorial Guinea", "Malabo", new List<string> { "Africa" }, "EquatorialGuinea.png"),
                    ("Mauritius", "Port Louis", new List<string> { "Africa" }, "Mauritius.png"),
                    ("Eswatini", "Mbabane", new List<string> { "Africa" }, "Eswatini.png"),
                    ("Djibouti", "Djibouti", new List<string> { "Africa" }, "Djibouti.png"),
                    ("Comoros", "Moroni", new List<string> { "Africa" }, "Comoros.png"),
                    ("Cabo Verde", "Praia", new List<string> { "Africa" }, "CaboVerde.png"),
                    ("São Tomé and Príncipe", "São Tomé", new List<string> { "Africa" }, "SaoTome.png"),
                    ("Seychelles", "Victoria", new List<string> { "Africa" }, "Seychelles.png"),

                    //Asia
                    ("India", "New Delhi", new List<string> { "Asia" }, "India.png"),
                    ("China", "Beijing", new List<string> { "Asia" }, "China.png"),
                    ("Indonesia", "Jakarta", new List<string> { "Asia" }, "Indonesia.png"),
                    ("Pakistan", "Islamabad", new List<string> { "Asia" }, "Pakistan.png"),
                    ("Bangladesh", "Dhaka", new List<string> { "Asia" }, "Bangladesh.png"),
                    ("Japan", "Tokyo", new List<string> { "Asia" }, "Japan.png"),
                    ("Philippines", "Manila", new List<string> { "Asia" }, "Philippines.png"),
                    ("Vietnam", "Vietnam", new List<string> { "Asia" }, "Vietnam.png"),
                    ("Turkey", "Ankara", new List<string> { "Asia" }, "Turkey.png"),
                    ("Thailand", "Bangkok", new List<string> { "Asia" }, "Thailand.png"),
                    ("Myanmar", "Naypyidaw", new List<string> { "Asia" }, "Myanmar.png"),
                    ("South Korea", "Seoul", new List<string> { "Asia" }, "SouthKorea.png"),
                    ("Iraq", "Baghdad", new List<string> { "Asia" }, "Iraq.png"),
                    ("Afghanistan", "Kabul", new List<string> { "Asia" }, "Afghanistan.png"),
                    ("Yemen", "Sana'a", new List<string> { "Asia" }, "Yemen.png"),
                    ("Uzbekistan", "Tashkent", new List<string> { "Asia" }, "Uzbekistan.png"),
                    ("Malaysia", "Kuala Lumpur", new List<string> { "Asia" }, "Malaysia.png"),
                    ("Saudi Arabia", "Riyadh", new List<string> { "Asia" }, "SaudiArabia.png"),
                    ("Nepal", "Kathmandu", new List<string> { "Asia" }, "Nepal.png"),
                    ("North Korea", "Pyongyang", new List<string> { "Asia" }, "NorthKorea.png"),
                    ("Syria", "Damascus", new List<string> { "Asia" }, "Syria.png"),
                    ("Kazakhstan", "Astana", new List<string> { "Asia", "Europe" }, "Kazakhstan.png"),
                    ("Cambodia", "Phnom Penh", new List<string> { "Asia" }, "Cambodia.png"),
                    ("Jordan", "Amman", new List<string> { "Asia" }, "Jordan.png"),
                    ("United Arab Emirates", "Abu Dhabi", new List<string> { "Asia" }, "UAE.png"),
                    ("Tajikistan", "Dushanbe", new List<string> { "Asia" }, "Tajikistan.png"),
                    ("Azerbaijan", "Baku", new List<string> { "Asia", "Europe" }, "Azerbaijan.png"),
                    ("Israel", "Jerusalem", new List<string> { "Asia" }, "Israel.png"),
                    ("Laos", "Vientiane", new List<string> { "Asia" }, "Laos.png"),
                    ("Turkmenistan", "Ashgabat", new List<string> { "Asia" }, "Turkmenistan.png"),
                    ("Kyrgyzstan", "Bishkek", new List<string> { "Asia" }, "Kyrgyzstan.png"),
                    ("Singapore", "Singapore", new List<string> { "Asia" }, "Singapore.png"),
                    ("Lebanon", "Beirut", new List<string> { "Asia" }, "Lebanon.png"),
                    ("Palestine", "Ramallah", new List<string> { "Asia" }, "Palestine.png"),
                    ("Oman", "Muscat", new List<string> { "Asia" }, "Oman.png"),
                    ("Kuwait", "Kuwait City", new List<string> { "Asia" }, "Kuwait.png"),
                    ("Georgia", "Tbilisi", new List<string> { "Asia", "Europe" }, "Georgia.png"),
                    ("Mongolia", "Ulaanbaatar", new List<string> { "Asia" }, "Mongolia.png"),
                    ("Qatar", "Doha", new List<string> { "Asia" }, "Qatar.png"),
                    ("Armenia", "Yerevan", new List<string> { "Asia" }, "Armenia.png"),
                    ("Bahrain", "Manama", new List<string> { "Asia" }, "Bahrain.png"),
                    ("Timor-Leste", "Dili", new List<string> { "Asia" }, "TimorLeste.png"),
                    ("Cyprus", "Nicosia", new List<string> { "Asia", "Europe" }, "Cyprus.png"),
                    ("Bhutan", "Bhutan", new List<string> { "Asia" }, "Bhutan.png"),
                    ("Maldives", "Malé", new List<string> { "Asia" }, "Maldives.png"),
                    ("Brunei", "Bandar Seri Begawan", new List<string> { "Asia" }, "Brunei.png"),
                    ("Taiwan", "Taipei", new List<string> { "Asia" }, "Taiwan.png"),
                    ("Iran", "Tehran", new List<string> { "Asia" }, "Iran.png"),
                    ("Sri Lanka", "Sri Jayawardenepura Kotte", new List<string> { "Asia" }, "SriLanka.png"),

                    //Oceania
                    ("Australia", "Canberra", new List<string> { "Oceania" }, "Australia.png"),
                    ("Papua New Guinea", "Port Moresby", new List<string> { "Oceania" }, "PapuaNewGuinea.png"),
                    ("New Zealand", "Wellington", new List<string> { "Oceania" }, "NewZealand.png"),
                    ("Fiji", "Suva", new List<string> { "Oceania" }, "Fiji.png"),
                    ("Solomon Islands", "Honiara", new List<string> { "Oceania" }, "SolomonIslands.png"),
                    ("Federated States of Micronesia", "Palikir", new List<string> { "Oceania" }, "Micronesia.png"),
                    ("Vanuatu", "Port Vila", new List<string> { "Oceania" }, "Vanuatu.png"),
                    ("Samoa", "Apia", new List<string> { "Oceania" }, "Samoa.png"),
                    ("Kiribati", "South Tarawa", new List<string> { "Oceania" }, "Kiribati.png"),
                    ("Tonga", "Nuku'alofa", new List<string> { "Oceania" }, "Tonga.png"),
                    ("Marshall Islands", "Majuro", new List<string> { "Oceania" }, "MarshallIslands.png"),
                    ("Palau", "Ngerulmud", new List<string> { "Oceania" }, "Palau.png"),
                    ("Nauru", "Yaren", new List<string> { "Oceania" }, "Nauru.png"),
                    ("Tuvalu", "Funafuti", new List<string> { "Oceania" }, "Tuvalu.png")
            };
        }

        public List<Country> GetallCountries()
        {
            return countryList;
        }
    }
}

