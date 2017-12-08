using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numbers = input.Split().Select(int.Parse).ToList();

            List<int> leftside = new List<int>();
            List<int> rightside = new List<int>();
            List<int> leftMidSide = new List<int>();
            List<int> rightMidSide = new List<int>();
            leftside.AddRange(numbers.Take((numbers.Count / 2) / 2));
            leftside.Reverse();
            numbers.Reverse();
            rightside.AddRange(numbers.Take((numbers.Count / 2) / 2));
            numbers.Reverse();
            leftMidSide.AddRange(numbers.Skip(leftside.Count).Take(leftside.Count));
            numbers.Reverse();
            rightMidSide.AddRange(numbers.Skip(rightside.Count).Take(rightside.Count));
            rightMidSide.Reverse();
            numbers.Reverse();

            for (int i = 0; i < leftside.Count; i++)
            {
                int result = leftside[i] + leftMidSide[i];
                Console.Write(result+" ");
            }
            for (int i = 0; i < rightside.Count; i++)
            {
                int result = rightside[i] + rightMidSide[i];
                Console.Write(result + " ");
            }
            Console.WriteLine();

        }
    }
}
