using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var resources = new Dictionary<string, decimal>();

            while (line != "stop")
            {
                var resource = line;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;

                line = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
