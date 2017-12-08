using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var ContinentsAndContries = new Dictionary<string, Dictionary<string, List<string>>>();
            while (n-- > 0)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!ContinentsAndContries.ContainsKey(continent))
                {
                    ContinentsAndContries.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!ContinentsAndContries[continent].ContainsKey(country))
                {
                    ContinentsAndContries[continent].Add(country, new List<string>());
                }
                ContinentsAndContries[continent][country].Add(city);
            }
            foreach (var cont in ContinentsAndContries)
            {
                Console.WriteLine(cont.Key+":");
                foreach (var count in cont.Value)
                {
                    Console.WriteLine($"{count.Key} -> {string.Join(", ",count.Value)}");
                }
            }
        }
    }
}
