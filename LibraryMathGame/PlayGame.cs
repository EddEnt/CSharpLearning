using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame
{
    internal class PlayGame
    {
        //Blueprint for Gametypes
        internal static int RunPlayGame(int min, int max, int numberOfQuestionsToPlay, string gameType)
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
                    Console.WriteLine($"Exiting the {gameType} game.");
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
                        // Exit the game
                        return correctAnswers;
                }
            }

            return correctAnswers;
        }
    }
}
