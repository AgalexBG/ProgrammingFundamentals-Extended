using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string privatemsgPattern = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadcastPattern = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";
            List<string> broadcasts = new List<string>();
            List<string> messages = new List<string>();
            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                Match broadcastMatch = Regex.Match(input, broadcastPattern);
                Match privatemsgMatch = Regex.Match(input, privatemsgPattern);

                if (broadcastMatch.Success)
                {
                    string frequency = broadcastMatch.Groups[2].Value;
                    string message = broadcastMatch.Groups[1].Value;
                    string newfrequency = "";
                    foreach (char ch in frequency)
                    {
                        if (char.IsUpper(ch))
                        {
                            newfrequency += ch.ToString().ToLower();
                        }
                        else if (char.IsLower(ch))
                        {
                            newfrequency += ch.ToString().ToUpper();
                        }
                        else
                        {
                            newfrequency += ch;
                        }
                    }
                    string broadcast = newfrequency + " -> " + message;
                    broadcasts.Add(broadcast);
                }
                if (privatemsgMatch.Success)
                {
                    string recipientcode = privatemsgMatch.Groups[1].Value;
                    string message = privatemsgMatch.Groups[2].Value;

                    string reversedCode = string.Join("", recipientcode.ToCharArray().Reverse());

                    string privatemessage = reversedCode + " -> " + message;
                    messages.Add(privatemessage);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\n", broadcasts));
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\n", messages));
            }

        }
    }
}
