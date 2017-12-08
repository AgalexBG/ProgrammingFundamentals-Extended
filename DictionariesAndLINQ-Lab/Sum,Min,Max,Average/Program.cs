using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Min_Max_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                int num = int.Parse(Console.ReadLine());

                list.Add(num);
            }
            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");
        }
    }
}
