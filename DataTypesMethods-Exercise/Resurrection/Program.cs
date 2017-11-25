using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long lenght = 0;
            decimal widht = 0;
            long wing = 0;
            decimal totalYears = 0;
            for (int i = 0; i < n; i++)
            {
                lenght = long.Parse(Console.ReadLine());
                widht = decimal.Parse(Console.ReadLine());
                wing = long.Parse(Console.ReadLine());

                totalYears = (lenght * lenght) * (widht + 2 * wing);
                Console.WriteLine(totalYears);
            }
        }
    }
}
