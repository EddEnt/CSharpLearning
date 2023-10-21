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
        internal static int RunPlayGame(int min, int max, int numberOfQuestionsToPlay, string gameType, List<string> generatedQuestions, List<string> userAnswers)
        {
            int numberOfQuestions = 0;
            int correctAnswers = 0;

            while (numberOfQuestions < numberOfQuestionsToPlay)
            {
                int num1 = new Random().Next(min, max + 1);
                int num2 = new Random().Next(min, max + 1);
                int correctAnswer = 0;
                string questionText = "";

                switch (gameType)
                {
                    case "Addition":
                        correctAnswer = num1 + num2;
                        questionText = $"What is {num1} + {num2}? ";
                        break;
                    case "Subtraction":
                        correctAnswer = num1 - num2;
                        questionText = $"What is {num1} - {num2}? ";
                        break;
                    case "Multiplication":
                        correctAnswer = num1 * num2;
                        questionText = $"What is {num1} * {num2}? ";
                        break;
                    case "Division":
                        if (num2 == 0)
                        {
                            correctAnswer = 0; // Indicate division by zero
                            questionText = $"What is {num1} / 0? (Enter 0 to indicate division by zero): ";
                        }
                        else
                        {
                            correctAnswer = num1 / num2;
                            questionText = $"What is {num1} / {num2}? ";
                        }
                        break;
                }

                Console.Write(questionText);
                string inputUserAnswer = Console.ReadLine().Trim().ToLower();

                // Store the generated question and user answer
                generatedQuestions.Add(questionText);
                Console.WriteLine($"Added question: {questionText}");
                userAnswers.Add(inputUserAnswer);
                Console.WriteLine($"Added user answer: {inputUserAnswer}");

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
                    Console.WriteLine($"Incorrect. The correct answer is {(correctAnswer == 0 ? "division by zero" : correctAnswer.ToString())}.");
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
