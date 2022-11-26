using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public interface IBirthDay
    {
        string BirthDate { get; set; }
        string BirthYear { get; }
    }
}
