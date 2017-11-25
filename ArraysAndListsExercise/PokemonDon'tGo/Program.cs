using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int sum = 0;
            while (input.Count >= 0)
            {
                int removedElement = 0;
                sum += removedElement;
                if (index < input.Count-1 && index >= 0)
                {
                    removedElement = input[index];
                    input.RemoveAt(index);
                    if (input.Count<= 0 )
                    {
                        break;
                    }
                    NewMethod(input, removedElement);
                }
                if (index<0)
                {
                    removedElement = input[0];
                    NewMethod(input, removedElement);
                    sum += removedElement;
                    input.RemoveAt(0);
                    if (input.Count <= 0)
                    {
                        break;
                    }
                    input[input.Count - 1] = removedElement;
                }
                if (index > input.Count-1)
                {
                    removedElement = input[input.Count - 1];
                    NewMethod(input, removedElement);
                    sum += removedElement;
                    input.RemoveAt(input.Count - 1);
                    if (input.Count <= 0)
                    {
                        break;
                    }
                    input[0] = removedElement;
                }
            }
            Console.WriteLine(sum);
        }

        private static void NewMethod(List<int> input, int removedElement)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= removedElement)
                {
                    input[i] += removedElement;
                }
                else
                {
                    input[i] -= removedElement;
                }
            }
        }

    }
}
