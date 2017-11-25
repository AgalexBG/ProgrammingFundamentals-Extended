using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num = int.Parse(Console.ReadLine());

            bool IsContained = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == num)
                {
                    IsContained = true;
                    break;
                }

            }
            if (IsContained)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
