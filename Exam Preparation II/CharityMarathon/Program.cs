using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long agrlaps = long.Parse(Console.ReadLine());
            long lenghtTrack = long.Parse(Console.ReadLine());
            long capacityTrack = long.Parse(Console.ReadLine());
            decimal moneyPerKill = decimal.Parse(Console.ReadLine());

            if (days*capacityTrack < runners)
            {
                runners = days * capacityTrack;
            }

            long totalMeters = runners * agrlaps * lenghtTrack;
            totalMeters = totalMeters / 1000;
            decimal Money = moneyPerKill * totalMeters;

            Console.WriteLine($"Money raised: {Money:f2}");
        }
    }
}
