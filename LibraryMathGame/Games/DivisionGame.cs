using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LibraryMathGame.Games
{
    public class DivisionGame
    {
        public static void StartDivisionGame()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Division Game");

            while (true)
            {
                int min, max;
                int numberOfQuestionsToPlay = 0;
                int correctAnswers = 0;
                List<string> generatedQuestions = new List<string>();
                List<string> userAnswers = new List<string>();

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

                correctAnswers = PlayGame.RunPlayGame(min, max, numberOfQuestionsToPlay, "Division", generatedQuestions, userAnswers);

                // Record the game session
                GameSessionManager.RecordGameSession("Division", difficulty, numberOfQuestionsToPlay, correctAnswers, generatedQuestions, userAnswers);

                if (!ContinueGame.AskToContinueGame())
                    return; // Exit division game
            }
        }   
    }
}

