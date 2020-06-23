using System;

namespace AgeChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("That's too bad, you need to wait a couple of years first.");
            }
            else if (age == 18)
            {
                Console.WriteLine("Phew, barely made it!");
            }
            else {
                Console.WriteLine("You are allowed to enter.");
            }
            Console.ReadKey();
        }
    }
}
