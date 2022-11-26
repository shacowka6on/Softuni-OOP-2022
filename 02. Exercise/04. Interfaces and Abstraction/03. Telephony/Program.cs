using System;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] websites     = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 7)
                {
                    stationaryPhone.Call(number);
                }
                else if (number.Length == 10)
                {
                    smartphone.Call(number);
                }
            }
            foreach (var site in websites)
            {
                smartphone.Browser(site);
            }
        }
    }
}
