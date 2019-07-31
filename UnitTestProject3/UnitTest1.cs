using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class TennisGameTest
    {
        [TestMethod]
        public void Love_All()
        {
            TennisGame tennisGame = new TennisGame();
            var score = tennisGame.Score();
            Assert.AreEqual("Love All", score);
        }
    }
}