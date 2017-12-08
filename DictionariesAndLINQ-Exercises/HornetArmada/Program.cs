using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class HornetLegion
    {
        public long LastActivity { get; set; }
        public string LegionName { get; set; }
        //public string SoldierType { get; set; }
        //public long SoldierCount { get; set; }
        public Dictionary<string, long> SoldierTypeAndCount{ get; set; }

        public HornetLegion()
        {
            SoldierTypeAndCount = new Dictionary<string, long>();
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var hornetArmada = new List<HornetLegion>();

            long n = long.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                HornetLegion currentLegion = new HornetLegion();
                bool vare = false;
                var input = Console.ReadLine().Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                currentLegion.LastActivity = lastActivity;
                currentLegion.LegionName = legionName;
                currentLegion.SoldierTypeAndCount.Add(soldierType, soldierCount);

                if (hornetArmada.Count == 0 )
                {
                    hornetArmada.Add(currentLegion);
                }
                else
                {
                    foreach (var hor in hornetArmada)
                    {
                        if (hor.LegionName == currentLegion.LegionName)
                        {
                            if (hor.SoldierTypeAndCount.ContainsKey(soldierType))
                            {
                                if (hor.SoldierTypeAndCount[soldierType] < soldierCount)
                                {
                                    long temp = hor.SoldierTypeAndCount[soldierType] += soldierCount;
                                    hor.SoldierTypeAndCount[soldierType]= temp;
                                    hor.LastActivity = hor.LastActivity + lastActivity;
                                    vare = false;
                                    break;
                                }
                            }
                            else
                            {
                                hor.SoldierTypeAndCount.Add(soldierType, soldierCount);
                            }
                            //foreach (var item in currentLegion.SoldierTypeAndCount.Keys)
                            //{
                            //    if (!hor.SoldierTypeAndCount.ContainsKey(item))
                            //    {
                            //        hor.SoldierTypeAndCount.Add(item, currentLegion.SoldierTypeAndCount[item]);

                            //        if (hor.SoldierTypeAndCount[item] < currentLegion.SoldierTypeAndCount[item])
                            //        {                                    
                            //            long temp = hor.SoldierTypeAndCount[item] += currentLegion.SoldierTypeAndCount[item];
                            //            hor.SoldierTypeAndCount.Add(item, temp);
                            //        }

                            //    }
                            //}
                            if (hor.LastActivity < lastActivity)
                            {
                                hor.LastActivity = lastActivity;
                            }
                            vare = false;
                            break;
                        }
                        else
                        {
                            vare = true;
                            //hornetArmada.Add(currentLegion);
                        }
                    }
                    if (vare)
                    {
                        hornetArmada.Add(currentLegion);
                    }
                }
                
                
            }
            var result = Console.ReadLine();
            if (result.Contains("\\"))
            {
                var result1 = result.Split('\\').ToArray();
                //var resultt = hornetArmada.Where(a => a.LastActivity < long.Parse(result1[0]));//.OrderByDescending(a => a.SoldierTypeAndCount.Values).ToList();
                //foreach (var hor in resultt)
                //{
                //    Console.WriteLine($"{hor.LegionName} -> {hor.SoldierTypeAndCount[result1[1].ToString()]}");
                //}
                foreach (var hor in hornetArmada.OrderByDescending(a => a.SoldierTypeAndCount.Values.Sum()))
                {
                    if (hor.SoldierTypeAndCount.ContainsKey(result1[1].ToString()))
                    {
                        if (hor.LastActivity < long.Parse(result1[0]))
                        {
                            Console.WriteLine($"{hor.LegionName} -> {hor.SoldierTypeAndCount[result1[1].ToString()]}");
                        }
                    }
                }
            }
            else
            {
                foreach (var hor in hornetArmada.OrderByDescending(a => a.LastActivity))
                {
                    
                    if (hor.SoldierTypeAndCount.ContainsKey(result))
                    {
                        Console.WriteLine($"{hor.LastActivity} : {hor.LegionName}");
                    }
                }
            }
        }
    }
}
