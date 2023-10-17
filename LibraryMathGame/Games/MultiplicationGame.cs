using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LibraryMathGame.Games
{
    public class MultiplicationGame
    {
        public static void StartMultiplicationGame()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Multiplication Game");

            while (true)
            {
                int min, max;
                int numberOfQuestions = 0;
                int questionsToPlay = 0;

                string difficulty = GetDifficultyLevel();
                if (difficulty == null)
                    return; // User exited to the main menu

                questionsToPlay = GetNumberOfQuestions();
                if (questionsToPlay == -1)
                    return; // User exited to the main menu

                SetDifficultyRange(difficulty, out min, out max);

                while (numberOfQuestions < questionsToPlay)
                {
                    int num1 = new Random().Next(min, max + 1);
                    int num2 = new Random().Next(min, max + 1);

                    Console.Write($"What is {num1} * {num2}? ");
                    string inputUserAnswer = Console.ReadLine().Trim().ToLower();

                    if (inputUserAnswer == "q")
                    {
                        Console.WriteLine("Exiting the multiplication game.");
                        return; // Exit multiplication game
                    }

                    if (int.TryParse(inputUserAnswer, out int userAnswer) && userAnswer == num1 * num2)
                    {
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect. The correct answer is {num1 * num2}.");
                    }

                    numberOfQuestions++;

                    if (numberOfQuestions % 5 == 0)
                    {
                        if (!AskToContinueGame())
                            return; // Exit multiplication game
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
            string difficulty;
            while (true)
            {
                Console.Write("Select the difficulty level (Easy, Regular, or Hard) or 'q' to return to the main menu: ");
                difficulty = Console.ReadLine().Trim().ToLower();

                if (difficulty == "q")
                    return null; // User exited to the main menu

                if (difficulty == "easy" || difficulty == "regular" || difficulty == "hard")
                    return difficulty;
                else
                    Console.WriteLine("Invalid difficulty level. Please try again.");
            }
        }

        private static int GetNumberOfQuestions()
        {
            int questionsToPlay;
            while (true)
            {
                Console.Write("Enter the number of questions or 'q' to return to the main menu: ");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "q")
                    return -1; // User exited to the main menu

                if (int.TryParse(input, out questionsToPlay) && questionsToPlay >= 1)
                    return questionsToPlay;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number or 'q' to return to the main menu.");
            }
        }

        private static void SetDifficultyRange(string difficulty, out int min, out int max)
        {
            min = 1;
            max = 10;

            if (difficulty == "regular")
            {
                max = 100;
            }
            else if (difficulty == "hard")
            {
                max = 1000;
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
                    return false; // Exit multiplication game
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }
    }
}

