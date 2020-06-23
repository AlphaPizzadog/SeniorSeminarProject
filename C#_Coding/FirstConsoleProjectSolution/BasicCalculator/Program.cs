using System;

namespace BasicCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num01;
            double num02;

            Console.Write("Type a number to be divided: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type another number: ");
            num02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("When " + num01 + " is divided by " + num02 + ", the result is " + num01 / num02);
            Console.ReadKey();
        }
    }
}
