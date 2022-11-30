using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CommandPattern.Core.Contracts
{
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
            => $"Hello, {args[0]}";
        
    }
}
