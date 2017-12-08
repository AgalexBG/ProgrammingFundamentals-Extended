using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada_v2._0
{
    class Hornet
    {
        public long LastActivity { get; set; }
        public string LegionName { get; set; }
        public Dictionary<string, long> TypeAndCount { get; set; }

        static Hornet()
        {
            Dictionary<string, long> TypeAndCount = new Dictionary<string, long>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            List<Hornet> hornetArmada = new List<Hornet>();
            while (n-- > 0)
            {
                bool HasANewHornet = false;
                var input = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                long lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string SoldierType = input[2];
                long SoldierCount = long.Parse(input[3]);

                Hornet currentHornet = new Hornet();
                currentHornet.TypeAndCount = new Dictionary<string, long>();
                currentHornet.LastActivity = lastActivity;
                currentHornet.LegionName = legionName;
                currentHornet.TypeAndCount.Add(SoldierType, SoldierCount);

                if (hornetArmada.Count == 0)
                {
                    hornetArmada.Add(currentHornet);
                }
                else
                {


                    foreach (var hor in hornetArmada)
                    {
                        if (hor.LegionName == legionName)
                        {
                            if (hor.TypeAndCount.ContainsKey(SoldierType))
                            {
                                hor.TypeAndCount[SoldierType] += SoldierCount;
                                if (hor.LastActivity < lastActivity)
                                {
                                    hor.LastActivity = lastActivity;
                                    HasANewHornet = false;
                                    break;
                                }
                                break;
                            }
                            if (hor.LastActivity < lastActivity)
                            {
                                hor.LastActivity = lastActivity;
                                HasANewHornet = false;
                            }
                            hor.TypeAndCount.Add(SoldierType, SoldierCount);
                            HasANewHornet = false;
                            break;
                        }
                        else
                        {
                            HasANewHornet = true;
                        }
                    }
                    if (HasANewHornet)
                    {
                        hornetArmada.Add(currentHornet);
                    }
                }

            }
            string output = Console.ReadLine();

            if (output.Contains("\\"))
            {
                var result = output.Split('\\').ToArray();

                foreach (var hor in hornetArmada.OrderByDescending(x => x.TypeAndCount.Values.Sum()))
                {
                    if (hor.LastActivity < long.Parse(result[0]) && hor.TypeAndCount.ContainsKey(result[1]))
                    {
                        Console.Write($"{hor.LegionName} -> {hor.TypeAndCount[result[1]]}");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var hor in hornetArmada.OrderByDescending(x => x.LastActivity))
                {
                    if (hor.TypeAndCount.ContainsKey(output))
                    {
                        Console.WriteLine($"{hor.LastActivity} : {hor.LegionName}");
                    }
                }
            }



        }
    }
}
