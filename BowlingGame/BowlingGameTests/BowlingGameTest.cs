using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game _game;

        [TestInitialize]
        public void SetUp()
        {
            _game = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
                _game.Roll(0);

            Assert.AreEqual(0, _game.Score(), "Score expected to be 0");
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, _game.Score(), "Score expected to be 20");
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                _game.Roll(pins);

        }
    }
}
