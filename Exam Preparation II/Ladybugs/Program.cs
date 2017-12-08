using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> field = new List<int>(fieldSize);

            for (int i = 0; i < fieldSize; i++)
            {
                field.Add(0);
            }


            for (int i = 0; i < ladybugIndexes.Length; i++)
            {
                if (ladybugIndexes[i] > field.Count - 1 || ladybugIndexes[i] < 0 || field[ladybugIndexes[i]] == 1)
                {
                    continue;
                }
                else
                {
                    field[ladybugIndexes[i]] = 1;
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                int index = int.Parse(command[0]);
                string direction = command[1];
                int flight = int.Parse(command[2]);

                if (index > field.Count - 1 || index < 0)
                {
                    continue;
                }
                if (flight == 0 || field[index] == 0)
                {
                    continue;
                }

                field[index] = 0;

                if (direction == "right")
                {
                    flight = FlyRight(field, index, flight);
                }
                else if (direction == "left")
                {
                    if (flight < 0)
                    {
                        flight = FlyRight(field, index, Math.Abs(flight));
                    }
                    else
                    {
                        flight = FlightLeft(field, index, flight);
                    }

                }
            }

            Console.WriteLine(string.Join(" ", field));

        }

        private static int FlightLeft(List<int> field, int index, int flight)
        {
            bool hasFoundNewPlace = false;
            while (hasFoundNewPlace != true)
            {
                if (/*(field.Count - 1) - (flight - index) < 0 ||*/ (field.Count - 1) - (flight) < 0)
                {
                    break;
                }
                if (field[flight] == 1)
                {
                    flight += flight;
                }
                else
                {
                    hasFoundNewPlace = true;
                }
            }
            if (hasFoundNewPlace)
            {
                field[index - flight] = 1;
            }

            return flight;
        }

        private static int FlyRight(List<int> field, int index, int flight)
        {
            bool foundNewPlace = false;
            while (foundNewPlace != true)
            {
                if (flight > field.Count - 1 || flight < 0 || flight + index > field.Count - 1 || field.Count + index < 0)
                {
                    break;
                }
                if (field[index + flight] == 1)
                {
                    flight = flight + flight;
                }
                else
                {
                    foundNewPlace = true;
                    break;
                }
            }
            if (foundNewPlace)
            {
                field[index+flight] = 1;
            }

            return flight;
        }
    }
}
