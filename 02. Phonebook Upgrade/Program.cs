using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var command = Console.ReadLine()
                .Split()
                .ToList();

            var phoneBook = new SortedDictionary<string, string>();
            var result = new List<string>();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "A":
                        phoneBook[command[1]] = command[2];
                        break;

                    case "S":
                        if (phoneBook.ContainsKey(command[1]))
                        {
                            result.Add($"{command[1]} -> {phoneBook[command[1]]}");
                        }
                        else
                        {
                            result.Add($"Contact {command[1]} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phoneBook)
                        {
                            result.Add($"{item.Key} -> {item.Value}");
                        }
                        break;
                }
                command = Console.ReadLine().Split().ToList();

            }
            foreach (var item in result)
            {

                Console.WriteLine(item);
            }
        }
    }
}
