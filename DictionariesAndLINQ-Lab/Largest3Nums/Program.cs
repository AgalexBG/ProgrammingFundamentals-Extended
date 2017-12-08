using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input = input.OrderByDescending(x => x).ToList();
            if (input.Count > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(input[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(string.Join(" ",input));
            }
            
        }
    }
}
