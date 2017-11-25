using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "3:1")
                {
                    break;
                }
                string cmd = command[0];


                if (cmd == "merge")
                {
                    int index = int.Parse(command[1]);
                    int endindex = int.Parse(command[2]);

                    if (index < 0 || index > input.Count - 1)
                    {
                        index = 0;
                    }
                    if (endindex < 0 || endindex > input.Count - 1)
                    {
                        endindex = input.Count - 1;
                    }

                    for (int j = index; j <= endindex; j++)
                    {
                        sb.Append(input[j]);
                    }
                    input.RemoveRange(index, endindex - index + 1);
                    input.Insert(index, sb.ToString());
                    sb = new StringBuilder();

                }
                if (cmd == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    string part = input[index];
                    List<string> newPart = new List<string>();
                    int parts = part.Length / partitions;
                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string element = part.Substring(0, parts);
                        newPart.Add(element);
                        part = part.Substring(parts);
                    }
                    newPart.Add(part);
                    input.RemoveAt(index);
                    newPart.Reverse();
                    for (int i = 0; i < newPart.Count; i++)
                    {
                        input.Insert(index, newPart[i]);

                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));            
        }
    }
}
