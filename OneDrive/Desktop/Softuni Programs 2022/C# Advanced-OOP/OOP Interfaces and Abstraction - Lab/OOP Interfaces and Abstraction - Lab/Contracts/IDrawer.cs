using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interfaces_and_Abstraction___Lab.Contracts
{
    public interface IDrawer
    {
        public void WriteLine(string text);
        public void Write(string text);
        public void WriteAtPosition(int row, int col, string text);

    }
}
