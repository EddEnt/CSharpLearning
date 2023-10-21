using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame
{
    public class GameSessionManager
    {
        public class GameSession
        {
            public string GameType { get; set; }
            public string Difficulty { get; set; }
            public int Questions { get; set; }
            public int CorrectAnswers { get; set; }
            public List<string> GeneratedQuestions { get; set; }
            public List<string> UserAnswers { get; set; }
        }

        private static List<GameSession> pastGameSessions = new List<GameSession>();

        public static void RecordGameSession(string gameType, string difficulty, int questions, int correctAnswers, List<string> generatedQuestions, List<string> userAnswers)
        {
            pastGameSessions.Add(new GameSession
            {
                GameType = gameType,
                Difficulty = difficulty,
                Questions = questions,
                CorrectAnswers = correctAnswers,
                GeneratedQuestions = generatedQuestions,
                UserAnswers = userAnswers
            });
        }

        public static List<GameSession> GetPastGameSessions()
        {
            return pastGameSessions;
        }
    }
}
