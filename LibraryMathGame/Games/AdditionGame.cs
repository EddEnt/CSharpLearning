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

            while (true)
            {
                int min, max;
                int numberOfQuestions = 0;
                int numberOfQuestionsToPlay = 0;

                // Choose difficulty level
                string difficulty = GetDifficultyLevel();
                if (difficulty == null)
                    return; // User exited to the main menu

                // Choose the number of questions
                numberOfQuestionsToPlay = GetNumberOfQuestions();
                if (numberOfQuestionsToPlay == -1)
                {
                    return; // User exited to the main menu
                }

                // Set min and max int range based on difficulty
                SetDifficultyRange(difficulty, out min, out max);

                while (numberOfQuestions < numberOfQuestionsToPlay)
                {
                    int num1 = new Random().Next(min, max + 1);
                    int num2 = new Random().Next(min, max + 1);

                    Console.Write($"What is {num1} + {num2}? ");
                    string inputUserAnswer = Console.ReadLine().Trim().ToLower();

                    if (inputUserAnswer == "q")
                    {
                        Console.WriteLine("Exiting the addition game.");
                        return; // Exit out of the addition game
                    }

                    if (int.TryParse(inputUserAnswer, out int userAnswer) && userAnswer == num1 + num2)
                    {
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect. The correct answer is {num1 + num2}.");
                    }

                    numberOfQuestions++;

                    if (numberOfQuestions % 5 == 0)
                    {
                        if (!AskToContinueGame())
                            return; // Exit addition game
                    }
                }

                // After all questions have been answered
                Console.Write("Do you want to play again? (yes/no) ");
                string playAgainResponse = Console.ReadLine().Trim().ToLower();

                if (playAgainResponse == "no")
                {
                    Console.WriteLine("Returning to the main menu.");
                    return; // Exit the game
                }
                else if (playAgainResponse != "yes")
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }

        private static string GetDifficultyLevel()
        {
            Console.Write("Select the difficulty level (Easy, Regular, or Hard): ");
            string difficulty = Console.ReadLine().Trim().ToLower();

            if (difficulty == "easy" || difficulty == "regular" || difficulty == "hard")
            {
                return difficulty;
            }
            else if (difficulty == "q")
            {
                Console.WriteLine("Returning to the main menu.");
                return null;
            }
            else
            {
                Console.WriteLine("Invalid difficulty level. Please try again.");
                return GetDifficultyLevel();
            }
        }

        private static void SetDifficultyRange(string difficulty, out int min, out int max)
        {
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
                    min = 0;
                    max = 0;
                    break;
            }
        }

        private static int GetNumberOfQuestions()
        {
            Console.Write("Enter the number of questions to play: ");
            if (int.TryParse(Console.ReadLine(), out int questions))
            {
                return questions;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return GetNumberOfQuestions();
            }
        }

        private static bool AskToContinueGame()
        {
            while (true)
            {
                Console.Write("Do you want to continue? (yes/no) ");
                string inputContinueQuestionGame = Console.ReadLine().Trim().ToLower();

                if (inputContinueQuestionGame == "yes")
                {
                    return true; // Continue game
                }
                else if (inputContinueQuestionGame == "no")
                {
                    Console.WriteLine("Returning to the main menu.");
                    return false; // Exit addition game
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }
    }
}


