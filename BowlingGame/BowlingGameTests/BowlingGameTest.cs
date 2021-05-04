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

        [TestMethod]
        public void TestOneSpare()
        {
            RollSpare();
            _game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, _game.Score(), "Score expected to be 16");
        }

        [TestMethod]
        public void TestOneStrike()
        {
            RollStrike();
            _game.Roll(3);
            _game.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, _game.Score(), "Score expected to be 24");
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, _game.Score(), "Score expected to be 300");
        }


        #region Private Methods
        private void RollStrike()
        {
            _game.Roll(10);
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                _game.Roll(pins);

        }
        #endregion Private Methods
    }
}
