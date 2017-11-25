using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var placeholder = Console.ReadLine().Split(new char[] {'{','}'},StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = @"([a-zA-Z]+)(.*)(\1)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            string result = "";
            
            int i = 0;
            foreach (Match m in matches)
            {
                string newValue = m.Groups[1].Value + placeholder[i] + m.Groups[3].Value;
                input = input.Replace(m.Value, newValue);
                
                i++;
            }
            Console.WriteLine(input);
        }
    }
}
