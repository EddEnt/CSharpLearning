using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame.Games
{
    public class AdditionGame
    {

        public static void StartAdditionGame()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Addition Game");

            Console.Write("Select the difficulty level (Easy, Regular, or Hard): ");
            string difficulty = Console.ReadLine().Trim().ToLower();

            int min, max;
            int numberOfQuestions = 0;

            switch (difficulty)
            {
                case "easy":
                    min = 1;
                    max = 10;
                    break;
                case "regular":
                    min = 1;
                    max = 100;
                    break;
                case "hard":
                    min = 1;
                    max = 1000;
                    break;
                default:
                    Console.WriteLine("Invalid difficulty level.");
                    return;
            }

            do
            {
                int num1 = new Random().Next(min, max + 1);
                int num2 = new Random().Next(min, max + 1);

                Console.Write($"What is {num1} + {num2}? ");
                if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == num1 + num2)
                {
                    Console.WriteLine("Correct answer!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is " + (num1 + num2) + ".");
                }

                numberOfQuestions++;

                if (numberOfQuestions % 5 == 0)
                {
                    Console.Write("Do you want to continue? (yes/no) ");
                    if (Console.ReadLine().ToLower() != "yes")
                    {
                        break; // Exit out of addition game
                    }
                }
            } while (true);

            Console.WriteLine("Returning you to the main menu...");
        }

    }
}
