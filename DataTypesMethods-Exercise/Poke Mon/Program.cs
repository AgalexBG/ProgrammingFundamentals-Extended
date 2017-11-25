using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePower = long.Parse(Console.ReadLine());
            long OrgPokePower = pokePower;
            long distance = long.Parse(Console.ReadLine());
            long exhaustionFactor = long.Parse(Console.ReadLine());
            long counter = 0;
            while (pokePower>=distance)
            {
                pokePower -= distance;
                counter++;
                if (pokePower == OrgPokePower*0.5 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
                
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
