using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame.Games
{
    public class SubtractionGame
    {

        public static void StartSubtractionGame()
        {
            string difficulty;
            int min, max;
            int numberOfQuestions = 0;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Subtraction Game");

            while (true)
            {
                Console.Write("Select the difficulty level (Easy, Regular, or Hard): ");
                difficulty = Console.ReadLine().Trim().ToLower();

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
                        Console.WriteLine("Invalid difficulty level. Please try again.");
                        continue; // Restart the loop to ask for difficulty again
                }

                do
                {
                    int num1 = new Random().Next(min, max + 1);
                    int num2 = new Random().Next(min, max + 1);

                    Console.Write($"What is {num1} - {num2}? ");
                    if (int.TryParse(Console.ReadLine(), out int inputUserAnswer) && inputUserAnswer == num1 - num2)
                    {
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. The correct answer is " + (num1 - num2) + ".");
                    }

                    numberOfQuestions++;

                    if (numberOfQuestions % 5 == 0)
                    {
                        while (true)
                        {
                            Console.Write("Do you want to continue? (yes/no) ");
                            string inputContinueQuestionGame = Console.ReadLine().Trim().ToLower();

                            if (inputContinueQuestionGame == "yes")
                            {
                                break; // Continue the game
                            }
                            else if (inputContinueQuestionGame == "no")
                            {
                                Console.WriteLine("Returning to the main menu.");
                                return; // Exit the subtraction game
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                            }
                        }
                    }
                } while (true);
            }
        }

    }
}
