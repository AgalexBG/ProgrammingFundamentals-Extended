using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] states = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int startingPossition = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                
                int damage = 1;
                if (commands[0] == "Supernova")
                {
                    break;
                }
                string direction = commands[0];
                int steps = int.Parse(commands[1]);
                if (direction == "left")
                {
                   
                    for (int i = 0; i < steps; i++)
                    {
                        
                        startingPossition--;
                        if (startingPossition == 0)
                        {
                            startingPossition = states.Length-1;
                            damage++;
                            states[startingPossition] -= damage;
                            continue;
                        }
                       
                        states[startingPossition] -= damage;                                              
                    }
                }
                if (direction == "right")
                {
                   
                    for (int i = 0; i < steps; i++)
                    {
                        startingPossition++;
                        if (startingPossition == states.Length - 1)
                        {
                            startingPossition = 0;
                            damage++;
                            states[startingPossition + 1] -= damage;
                            continue;
                        }
                        states[startingPossition + 1] -= damage;
                        
                        
                    }
                }
            }
            Console.WriteLine(string.Join(" ",states));

        }
    }
}
