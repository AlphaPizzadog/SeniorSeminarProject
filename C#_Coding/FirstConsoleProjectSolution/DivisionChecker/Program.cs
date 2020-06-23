using System;

namespace DivisionChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 21;
            int num2 = 3;
            int userAnswer;

            Console.WriteLine("What is " + num1 + " divided by " + num2 + "?");
            userAnswer = Convert.ToInt32(Console.ReadLine());
            
            if (userAnswer == (num1 / num2))
            {
                Console.WriteLine("That's correct!");
            }
            else {
                Console.WriteLine("Hmm, you need to try again.");
            }
            
            Console.ReadKey();
        }
    }
}
