using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Population_Counter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split('|').ToList();

            var countries = new Dictionary<string, List<string>>();
            var citys = new Dictionary<string, long>();
            var totalPopulation = new Dictionary<string, long>();
            while (line[0] != "report")
            {
                var country = line[1];
                var city = line[0];
                var population = long.Parse(line[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new List<string>());

                }
                if (!citys.ContainsKey(city))
                {
                    citys.Add(city, 0);
                }
                if (!totalPopulation.ContainsKey(country))
                {
                    totalPopulation.Add(country, 0);
                }
                totalPopulation[country] += population;
                countries[country].Add(city);
                citys[city] += population;

                line = Console.ReadLine().Split('|').ToList();
            }
            var totalPopulationList = totalPopulation.OrderByDescending(key => key.Value).ToList();

            foreach (var item in totalPopulationList)
            {
                var country = item.Key;
                var countryPop = item.Value;

                Console.WriteLine($"{country} (total population: {countryPop})");
                var cityList = citys.OrderByDescending(key => key.Value).ToList();

                foreach (var AllCity in cityList)
                {

                    var citysCity = AllCity.Key;

                    foreach (var city in countries[country])
                    {
                        if (city==citysCity)
                        {
                            Console.WriteLine($"=>{city}: {AllCity.Value}");
                        }
                    }
                    
                }
            }
        }
    }
}
