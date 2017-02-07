using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var data= new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var log = Console.ReadLine().Split().ToList();


                var name = log[1];
                var ip = log[0];
                var duration = int.Parse(log[2]);

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new SortedDictionary<string, int>());
                }
                if (!data[name].ContainsKey(ip))
                {
                    data[name][ip] = 0;
                }
                data[name][ip] += duration;
            }

            foreach (var pair in data)
            {
                var sum = pair.Value.Values.Sum();

                Console.Write($"{pair.Key}: {sum} ");
                Console.Write("[");
                Console.Write(string.Join(", ",pair.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
