using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(<\[{1}[^A-Za-z0-9]*\]{1}\.{1}){1}(\.{1}\[{1}[A-Za-z0-9]*\]{1}\.{1})*$";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (true)
            {
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
                input = Console.ReadLine();
                match = regex.Match(input);
                if (input == "Traincode!")
                {
                    break;
                }
                
            }
           

        }
    }
}
