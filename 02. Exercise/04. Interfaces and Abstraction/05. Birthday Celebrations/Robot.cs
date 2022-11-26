using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Robot : IID
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public void CheckID(string ID)
        {
            if (Id.EndsWith(ID))
            {
                Console.WriteLine(Id);
            }
        }
    }
}
