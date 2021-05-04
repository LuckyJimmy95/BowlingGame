using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void TestGutterGame()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
                g.Roll(0);

            Assert.AreEqual(0, g.Score(), "Score expected to be 0");

        }
    }
}
