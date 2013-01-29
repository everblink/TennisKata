using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlayersMustBeAbleToScorePoints()
        {
            Game game = new Game();

            const int points = 2;
            int score = game.Score(points);

            Assert.AreEqual(30, score);
        }
    }
}
