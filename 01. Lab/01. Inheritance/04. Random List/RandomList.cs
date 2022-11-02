using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string> 
    {
        public string RandomString()
        {
            Random random = new Random();
            string removed = this[random.Next(Count)];
            RemoveAt(random.Next(Count));
            return removed;
        }
    }
}
