using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ICaller, IBrowser
    {
        public void Browser(string website)
        {
            if (website.Any(d => char.IsDigit(d)))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");
            }
        }

        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(ch => !char.IsDigit(ch)))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {phoneNumber}");
            }
        }
    }
}
