using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }
            var result = new List<string>();
            foreach (var item in words.Keys)
            {
                if (words[item] % 2 ==1)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
