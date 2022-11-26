using System;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class StartUp
    {
        static void Main()
        {
            List<IID> checkList = new List<IID>();
            while (true)
            {
                string cmd = Console.ReadLine();
                if(cmd == "End")
                {
                    break;
                }

                string[] tokens = cmd.Split();
                if (tokens.Length == 3)
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    checkList.Add(citizen);
                }
                else
                {
                    Robot robot = new Robot(tokens[0], tokens[1]);
                    checkList.Add(robot);
                }
            }
            string targetID = Console.ReadLine();
            foreach (var property in checkList)
            {
                property.CheckID(targetID);
            }
        }
    }
}
