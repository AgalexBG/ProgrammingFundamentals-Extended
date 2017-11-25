using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            input = input.OrderByDescending(a => a).ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                result.Add(input[i]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
