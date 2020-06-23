using System;
using System.Collections.Generic;

namespace GenericsProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Utility.CompareValue("hello me boyo", "hello me boyo"));
            Console.WriteLine(Utility.CompareType("helo","10"));

            Console.ReadKey();
        }
    }
    class Utility
    {
        public static bool CompareValue<T1, T2>(T1 value1, T2 value2) 
        {
            return value1.Equals(value2);
        }
        public static bool CompareType<T1, T2>(T1 type1, T2 type2)
        {
            return typeof(T1).Equals(typeof(T2));
        }
    }
}
