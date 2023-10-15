using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame.Games
{
    public class DivisionGame
    {
            public static void StartDivisionGame()
            {
                string difficulty;
                int min, max;
                int numberOfQuestions = 0;

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Division Game");

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

                        if (num2 == 0)
                        {
                            // Handle division by zero
                            Console.Write($"What is {num1} / 0? (Enter 0 to indicate division by zero): ");
                        }
                        else
                        {
                            Console.Write($"What is {num1} / {num2}? ");
                        }

                        if (int.TryParse(Console.ReadLine(), out int inputUserAnswer))
                        {
                            if ((num2 == 0 && inputUserAnswer == 0) || (num2 != 0 && inputUserAnswer == num1 / num2))
                            {
                                Console.WriteLine("Correct answer!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect. The correct answer is " + (num2 == 0 ? "division by zero" : (num1 / num2).ToString()) + ".");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
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
                                    break; // Continue game
                                }
                                else if (inputContinueQuestionGame == "no")
                                {
                                    Console.WriteLine("Returning to the main menu.");
                                    return; // Exit division game
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
