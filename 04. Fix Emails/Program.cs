using System;
using System.Collections.Generic;

namespace _04.Fix_Emails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var EaddresBook = new Dictionary<string, string>();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                if (!EaddresBook.ContainsKey(name))
                {
                    EaddresBook.Add(name, email);
                    if (email.Contains(".us"))
                    {

                        EaddresBook.Remove(name);
                    }
                    if (email.Contains(".uk"))
                    {
                        EaddresBook.Remove(name);
                    }
                }
                line = Console.ReadLine();
            }
            foreach (var item in EaddresBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}