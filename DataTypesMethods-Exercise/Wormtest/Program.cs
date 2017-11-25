using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            long lenghtMeters = long.Parse(Console.ReadLine());
            decimal widthCM = decimal.Parse(Console.ReadLine());
            long lenghtCM = lenghtMeters *100;
            if (widthCM == 0)
            {
                Console.WriteLine($"{lenghtCM * widthCM:f2}");
                return;
            }
            decimal division = lenghtCM % widthCM;

            if (division == 0 || widthCM == 0 )
            {
                Console.WriteLine($"{lenghtCM * widthCM:f2}");
            }
            else
            {
                decimal percentige = (lenghtCM / widthCM)*100;
                Console.WriteLine($"{percentige:f2}%");
            }
        }
    }
}
