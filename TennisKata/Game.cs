namespace TennisKata
{
    public class Game
    {
        public int Score(int points)
        {
            const int score = 0;

            if (points == 1)
                return (int) Scoring.Fifteen;
            if (points == 2)
                return (int) Scoring.Thirty;
            if (points == 3)
                return (int) Scoring.Forty;
            return (int) Scoring.Love;
        }
    }
}