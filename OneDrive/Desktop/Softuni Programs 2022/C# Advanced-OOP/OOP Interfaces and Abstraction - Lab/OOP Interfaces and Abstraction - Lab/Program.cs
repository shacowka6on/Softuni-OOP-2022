using OOP_Interfaces_and_Abstraction___Lab.Contracts;
using System;

namespace Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDrawer drawer = new ConsoleDrawer();

            drawer.Write("Hello");
            drawer.WriteAtPosition(14, 53, "Hello cunt"); 

            Circle circle = new Circle();
            circle.Draw();
        }
    }
}
