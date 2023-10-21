using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMathGame;

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
                int correctAnswers = 0;

                // Choose difficulty level
                string difficulty = Difficulty.GetDifficultyLevel();
                if (difficulty == null)
                    return; // User is exited to the main menu

                // Choose the number of questions
                numberOfQuestionsToPlay = NumberOfQuestions.GetNumberOfQuestions();
                if (numberOfQuestionsToPlay == -1)
                {
                    return; // User exits to the main menu
                }

                // Set min and max int range based on difficulty
                Difficulty.SetDifficultyRange(difficulty, out min, out max);

                correctAnswers = PlayAdditionGame(min, max, numberOfQuestionsToPlay);

                // Record the game session
                GameSessionManager.RecordGameSession("Addition", difficulty, numberOfQuestionsToPlay, correctAnswers);

                if (!ContinueGame.AskToContinueGame())
                    return; // Exit addition game
            }
        }


        private static int PlayAdditionGame(int min, int max, int numberOfQuestionsToPlay)
        {
            int numberOfQuestions = 0;
            int correctAnswers = 0;

            while (numberOfQuestions < numberOfQuestionsToPlay)
            {
                int num1 = new Random().Next(min, max + 1);
                int num2 = new Random().Next(min, max + 1);

                Console.Write($"What is {num1} + {num2}? ");
                string inputUserAnswer = Console.ReadLine().Trim().ToLower();

                if (inputUserAnswer == "q")
                {
                    Console.WriteLine("Exiting the addition game.");
                    return correctAnswers;
                }

                if (int.TryParse(inputUserAnswer, out int userAnswer) && userAnswer == num1 + num2)
                {
                    Console.WriteLine("Correct answer!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {num1 + num2}.");
                }

                numberOfQuestions++;

                if (numberOfQuestions % 5 == 0)
                {
                    if (!ContinueGame.AskToContinueGame())
                        return correctAnswers; // Exit addition game
                }
            }

            return correctAnswers;
        }

    }
}


