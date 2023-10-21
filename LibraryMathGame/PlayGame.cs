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
                int correctAnswer = 0;

                switch (gameType)
                {
                    case "Addition":
                        correctAnswer = num1 + num2;
                        Console.Write($"What is {num1} + {num2}? ");
                        break;
                    case "Subtraction":
                        correctAnswer = num1 - num2;
                        Console.Write($"What is {num1} - {num2}? ");
                        break;
                    case "Multiplication":
                        correctAnswer = num1 * num2;
                        Console.Write($"What is {num1} * {num2}? ");
                        break;
                    case "Division":
                        correctAnswer = num1 / num2;
                        Console.Write($"What is {num1} / {num2}? ");
                        break;
                }

                string inputUserAnswer = Console.ReadLine().Trim().ToLower();

                if (inputUserAnswer == "q")
                {
                    Console.WriteLine($"Exiting the {gameType} game.");
                    return correctAnswers;
                }

                if (int.TryParse(inputUserAnswer, out int userAnswer) && userAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct answer!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {correctAnswer}.");
                }

                numberOfQuestions++;

                if (numberOfQuestions % 5 == 0)
                {
                    if (!ContinueGame.AskToContinueGame())
                        return correctAnswers; // Exit the game
                }
            }

            return correctAnswers;
        }

    }
}
