using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List < string > Broadcasts = new List<string>();
            List<string> Privatemsges = new List<string>();
            string patternPrivateMeseage = @"^([0-9]+) <-> ([0-9]*[A-Za-z]*)$";
            string patternBroadcast = @"^([^0-9]+) <-> ([A-Za-z0-9]*)$";

            Regex privatemsgregex = new Regex(patternPrivateMeseage);

            Regex broadcastregex = new Regex(patternBroadcast);

            MatchCollection privatemsgMaches = privatemsgregex.Matches(input);
            MatchCollection broadcastMaches = broadcastregex.Matches(input);
            while (input != "Hornet is Green")
            {
                Match privatemsgmatch = privatemsgregex.Match(input);
                Match broadcastmatch = broadcastregex.Match(input);
                if (privatemsgmatch.Success)
                {
                    var resersed = privatemsgmatch.Groups[1].Value.ToCharArray().Reverse();
                    string reversedCode = string.Join("", resersed);
                    Privatemsges.Add(reversedCode + " -> " + privatemsgmatch.Groups[2].Value);
                }
               
                if (broadcastmatch.Success)
                {
                    string newvar = "";
                    foreach (var ch in broadcastmatch.Groups[2].Value)
                    {
                        if (Char.IsUpper(ch))
                        {
                            newvar += ch.ToString().ToLower();
                        }
                        if(Char.IsLower(ch))
                        {
                            newvar += ch.ToString().ToUpper();
                        }
                    }
                    string broadcast = newvar + " -> " + broadcastmatch.Groups[1].Value;
                    Broadcasts.Add(broadcast);
                }
               
                input = Console.ReadLine();
                privatemsgMaches = privatemsgregex.Matches(input);
                broadcastMaches = broadcastregex.Matches(input);
            }
            Privatemsges.Distinct();
            Broadcasts.Distinct();
            Console.WriteLine("Broadcasts:");
            if (Broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\n", Broadcasts));
            }
            
            Console.WriteLine("Messages:");
            if (Privatemsges.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\n", Privatemsges));
            }
        }
    }
}
