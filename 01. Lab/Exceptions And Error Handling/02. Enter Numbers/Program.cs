using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (numbers.Count < 10)
            {
                try
                {
                    if (!numbers.Any())
                    {
                        numbers.Add(ReadNumber(1, 100));
                    }
                    else
                    {
                        numbers.Add(ReadNumber(numbers.Max(), 100));
                    }
                }
                catch(FormatException formatEx)
                {
                    Console.WriteLine(formatEx.Message);
                }
                catch(ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
        static int ReadNumber(int start, int end)
        {
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Number!");
            }

            if (num <= start || num >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - {end}!");
            }
            return num;
        }
    }
}
