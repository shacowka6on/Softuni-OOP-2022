using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : ICaller
    {
        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(ch => !char.IsDigit(ch)))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Dialing... {phoneNumber}");
            }
        }
    }
}
