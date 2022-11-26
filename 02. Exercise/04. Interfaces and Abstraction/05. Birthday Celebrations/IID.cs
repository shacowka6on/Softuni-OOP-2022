using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public interface IID
    {
        string Name { get; }
        string Id { get; }
        void CheckID(string ID);
    }
}
