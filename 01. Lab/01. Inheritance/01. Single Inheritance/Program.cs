using System;

namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer1 = new Programmer();
            Programmer programmer2 = new Programmer("Gosho");
            Programmer programmer3 = new Programmer(5000, "Petur", 4);

            programmer1.CreateBugs();
            programmer2.CreateBugs();
            programmer3.CreateBugs();
        }
    }
}
