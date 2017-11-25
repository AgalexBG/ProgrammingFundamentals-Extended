using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int rotations = int.Parse(Console.ReadLine());

            for (int j = 0; j < rotations % input.Length; j++)
            {
                string Lastindex = input[input.Length - 1];
                for (int i = input.Length - 1; i > 0; i--)
                {
                    input[i] = input[i - 1];

                }
                input[0] = Lastindex;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
