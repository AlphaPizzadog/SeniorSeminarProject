using System;

namespace RandomMultiplyChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int num1 = numberGenerator.Next(1,11);
            int num2 = numberGenerator.Next(1,11);
            int userAnswer;
            int correctAnswer = num1 * num2;

            Console.WriteLine("What is " + num1 + " times " + num2 + "?");
            userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == correctAnswer)
            {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("That's correct!");
                        break;
                    case 2:
                        Console.WriteLine("Absolutely right!");
                        break;
                    default:
                        Console.WriteLine("You're doing great!");
                        break;
                }
            }
            else
            {
                int difference = Math.Abs(correctAnswer - userAnswer);
                
                if (difference <= 10) {
                    Console.WriteLine("So close! The correct answer is " + correctAnswer + ". You were only " + difference + " off.");
                }
                else {
                    Console.WriteLine("The correct answer is " + correctAnswer + ". You were " + difference + " off.");
                }
            }

            Console.ReadKey();
        }
    }
}
