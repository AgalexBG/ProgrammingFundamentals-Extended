using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataBases = new Dictionary<string,Dictionary<string,long>>();
            var dataasets =new List<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { '>','-',' ','|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0] == "thetinggoesskrra")
                {
                    break;
                }
                string dataKey = input[0];
                if (input.Length == 1)
                {
                    if (!dataBases.ContainsKey(dataKey))
                    {
                        dataBases.Add(dataKey, new Dictionary<string, long>());
                    }
                    dataasets.Add(dataKey);
                }
                else
                {
                    long dataSize = long.Parse(input[1]);
                    string dataSet = input[2];

                    if (!dataBases.ContainsKey(dataSet))
                    {
                        dataBases.Add(dataSet, new Dictionary<string, long>());
                    }
                    dataBases[dataSet].Add(dataKey, dataSize);
                }               
            }
            //dataBases.ToList().Where(a => !dataasets.Contains(a.Key)).ToList().ForEach(a => dataBases.Remove(a.Key));
            //neshto koeto ne razbiram mnogo no e kato foreach po otdoolu
            dataBases = dataBases.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(p => p.Key, p => p.Value);
            foreach (var item in dataBases.Keys)
            {
                if (!dataasets.Contains(item))
                {
                    dataBases.Remove(item);
//malko zalagash zadachata zashto ako ima poveche ot 1 ne sashtestvuvashto nqma da raboti zashto shte iztrie samo 1
                    break;
                }
            }
            foreach (var database in dataBases)
            {
                Console.WriteLine($"Data Set: {database.Key}, Total Size: {database.Value.Values.Sum()}");
                foreach (var datasets in database.Value)
                {
                    Console.WriteLine($"$.{datasets.Key}");
                }
                break;
            }
        }
    }
}
