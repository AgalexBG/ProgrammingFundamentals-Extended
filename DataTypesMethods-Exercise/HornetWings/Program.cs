using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            decimal distance = decimal.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            decimal traveledDistance = (wingFlaps/1000)*distance;
            Console.WriteLine($"{traveledDistance:f2} m.");
            decimal time1 = wingFlaps / 100;
            decimal time2 = time1 + (wingFlaps / endurance) * 5;
            Console.WriteLine($"{time2} s.");


        }
    }
}
