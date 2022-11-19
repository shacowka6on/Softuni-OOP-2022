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
        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldInfo field in classFields)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be private!");
            }
            foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be public!");
            }
            return stringBuilder.ToString().Trim();
        }
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();
            
            Type type = Type.GetType(className);
            MethodInfo[] classMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");
            foreach (MethodInfo method in classMethods)
            {
                Console.WriteLine(method.Name);
            }
            return sb.ToString().Trim();
        }
    }
}
