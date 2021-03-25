using System;
using System.Collections.Generic;

namespace ConsoleApp1._30DaysOfCode
{
    public class DictionariesAndMaps
    {
        public static void calculate()
        {
            int count=Convert.ToInt32(Console.ReadLine());
            Dictionary<string, double> phoneDictionary = new Dictionary<string, double>();
            List<string> queries = new List<string>();
            string searchName;

            for(int i = 1; i <= count; i++)
            {
                var result = Console.ReadLine().Split(' ');
                phoneDictionary.Add(result[0], Convert.ToDouble(result[1]));
            }

            do
            {
                searchName = Console.ReadLine();
                if (searchName != "")
                {
                    queries.Add(searchName);
                }
            } while (searchName != null);

            double resultValue;
            foreach (var query in queries)
            {
                if (!string.IsNullOrEmpty(query))
                {
                    if (phoneDictionary.TryGetValue(query, out resultValue))
                    {
                        Console.WriteLine("{0}={1}", query, resultValue);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
            }
        }
    }
}
