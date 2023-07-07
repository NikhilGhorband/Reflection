using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProblem2
{
    public class FindTheNumber
    {
        public static void ReflectionInfo()
        {
            Type type = typeof(FindTheNumber);


            Console.WriteLine("FullClass Name is: " + type.FullName);


            Console.WriteLine("ClassName is: " + type.Name + "\n");

            Console.WriteLine("Methods used in Class Customer is as follows");

            MethodInfo[] methods = type.GetMethods();


            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method Name: " + method.Name + " " + "Method RetrunType: " + method.ReturnType.Name);
            }


            Console.WriteLine("\nProperties of Class FindTheNumber");

            PropertyInfo[] properties = type.GetProperties();


            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + ": " + property.Name);
            }


            Console.WriteLine("\nConstructor Present in FindTheNumber class");

            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
