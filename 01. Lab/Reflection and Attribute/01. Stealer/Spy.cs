using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        
        public string StealFieldInfo(string classToInvestigate, params string[] fieldNames)
        {
            Type classType = Type.GetType(classToInvestigate);
            FieldInfo[] classFields = classType.GetFields
                                      (BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });
            sb.AppendLine($"Class under investigation: {classToInvestigate}");
            foreach (FieldInfo fieldInfo in classFields.Where(f => fieldNames.Contains(f.Name)))
            {
                sb.AppendLine($"{fieldInfo.Name} = {fieldInfo.GetValue(classInstance)}");
            }
            return sb.ToString().Trim();
        }
    }
}
