using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securitykey = int.Parse(Console.ReadLine());
            List<string> sitenames = new List<string>();
            decimal totalLoss = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string siteName = input[0];
                sitenames.Add(siteName);
                uint siteVisits = uint.Parse(input[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
            }
            foreach (var site in sitenames)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securitykey, sitenames.Count)}");
        }
    }
}
