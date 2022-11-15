using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PlayCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int exeptionsCount = 0;
            while (exeptionsCount < 3)
            {
                string[] cmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (cmd[0])
                    {
                        case "Replace": Repalce(numbers, cmd); break;
                        case "Print":Print(numbers, cmd);break;
                        case "Show":Show(numbers, cmd);break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exeptionsCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exeptionsCount++;
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }

        private static void Show(int[] numbers, string[] cmd)
        {
            int index = int.Parse(cmd[1]);
            Console.WriteLine(numbers[index]);
        }

        private static void Print(int[] numbers, string[] cmd)
        {
            int start = int.Parse(cmd[1]);
            int end = int.Parse(cmd[2]);

            List<int> printNumbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                printNumbers.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(", ", printNumbers));
        }

        private static void Repalce(int[] numbers, string[] cmd)
        {
            int index = int.Parse(cmd[1]);
            int element = int.Parse(cmd[2]);

            numbers[index] = element;
        }
    }
}
    