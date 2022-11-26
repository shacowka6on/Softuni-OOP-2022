using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthDay> birthdays = new List<IBirthDay>();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;

                string[] tokens = cmd.Split(' ');
                switch (tokens[0])
                {
                    case "Pet":
                        birthdays.Add(new Pet(tokens[1], tokens[2]));
                        break;
                    case "Citizen":
                        birthdays.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                        break;
                }
            }
            string targetYear = Console.ReadLine();
            foreach (var year in birthdays.Where(x => x.BirthYear == targetYear))
            {
                Console.WriteLine(year.BirthDate);
            }
        }
    }
}
