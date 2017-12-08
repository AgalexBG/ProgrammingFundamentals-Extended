using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string BojomonPattern = @"([A-Za-z]+)-[A-Za-z]+";
            string DidimonPattern = @"[^A-Za-z\-]+";

            Regex DidimonRegex = new Regex(DidimonPattern);
            Regex bojomonRegex = new Regex(BojomonPattern);
            while (true)
            {
                Match DidimonMatch = DidimonRegex.Match(input);
                if (DidimonMatch.Success)
                {
                    input = input.Substring(input.IndexOf(DidimonMatch.Value) + DidimonMatch.Value.Length);
                    Console.WriteLine(DidimonMatch.Value);
                }
                else
                {
                    break;
                }               
                Match BojomonMatch = bojomonRegex.Match(input);
                if (BojomonMatch.Success)
                {
                    input = input.Substring(input.IndexOf(BojomonMatch.Value) + BojomonMatch.Value.Length);
                    Console.WriteLine(BojomonMatch.Value);
                }
                else
                {
                    break;
                }
               
                

            }
        }
    }
}
