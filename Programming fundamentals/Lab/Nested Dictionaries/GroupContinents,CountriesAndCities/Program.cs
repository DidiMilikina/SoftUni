using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupContinents_CountriesAndCities
{
    class Program
    {
        static void Main(string[] args)
        {
            var continets = new SortedDictionary<string,
                SortedDictionary<string, SortedSet<string>>>();

            var numberContinents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberContinents; i++)
            {
                var tokens = Console.ReadLine().Split();
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!continets.ContainsKey(continent))
                {
                    continets[continent] =
                        new SortedDictionary<string, SortedSet<string>>();
                }
                if (!continets[continent].ContainsKey(country))
                {
                    continets[continent][country] = new SortedSet<string>();
                }

                continets[continent][country].Add(city);
            }

            foreach (var countinentAndCountry in continets)
            {
                var continentName = countinentAndCountry.Key;
                var country = countinentAndCountry.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var countryCity in country)
                {
                    var countryName = countryCity.Key;
                    var cityName = countryCity.Value;

                    Console.WriteLine($" {countryName} -> {string.Join(", ", cityName)}");
                }
            }
        }
    }
}