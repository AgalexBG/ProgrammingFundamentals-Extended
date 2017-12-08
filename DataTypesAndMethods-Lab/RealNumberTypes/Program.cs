using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealNumberTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 16)
            {
                double number = double.Parse(Console.ReadLine());

                Console.WriteLine(number);
            }
            else
            {
                decimal number = decimal.Parse(Console.ReadLine());

                Console.WriteLine(number);
            }
        }
    }
}
