﻿using System.Reflection;

namespace ReflectionProblem2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select your choice from:\n" +
               "1. To find Closest Even number with all even digit.\n" +
               "2. Fetch all class members (like methods, constructors,properties) using reflection.\n" +
               "3. Create empty object (default constructor) of above class using reflection.\n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    ClosestNumber.FindNumber();
                    break;
                case 2:
                    Console.WriteLine("Fetch all Class Methods using Reflection");
                    Type type = typeof(ClosestNumber);
                    MemberInfo[] members = type.GetMembers();

                    foreach (MemberInfo member in members)
                    {
                        Console.WriteLine(member);
                    }
                    break;
                case 3:
                    Console.WriteLine("--------Create empty object----------");
                    Type type1 = typeof(ClosestNumber);
                    object obj = Activator.CreateInstance(type1);
                    Console.WriteLine(obj.GetType().Name);
                    break;
            }

        }
    }
}