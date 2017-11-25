using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 ==1 && Math.Abs(input[i]) % 2 == 1)
                {
                    Console.WriteLine($"Index {i} -> {input[i]}");
                }
            }
        }
    }
}
