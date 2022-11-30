using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split();
            string cmd = tokens[0] + "Command";
            string[] value = tokens.Skip(1).ToArray();

            Type type = Assembly.GetCallingAssembly().GetTypes().First(x => x.Name == cmd);
            ICommand command = Activator.CreateInstance(type) as ICommand;

            return command.Execute(value);
        }
    }
}
