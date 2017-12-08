using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            while (n --> 0)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (!grades.ContainsKey(input[0]))
                {
                    grades.Add(input[0], new List<double>());
                    grades[input[0]].Add(double.Parse(input[1]));
                    
                }
                else
                {
                    grades[input[0]].Add(double.Parse(input[1]));
                }
            }
            foreach (var st in grades)
            {
                Console.Write($"{st.Key} -> ");
                foreach (var grade in st.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {st.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
