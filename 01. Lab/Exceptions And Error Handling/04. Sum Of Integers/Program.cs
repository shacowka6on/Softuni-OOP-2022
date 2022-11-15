using System;

namespace _04.SumOfIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;
            foreach (var item in input)
            {
                try
                {
                    sum += int.Parse(item);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }
                catch(OverflowException)
                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
