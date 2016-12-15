using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        [SetUp]
        public void SetUp()
        {
            _ui = new TestUi();
        }

        private Game _testObj;
        private TestUi _ui;

        private void SetupGame()
        {
            _testObj = Game.Create(0, 0);
            _testObj.SetUi(_ui);
        }

        [Test]
        public void TestCreate()
        {
            _testObj = Game.Create(0, 0);
            Assert.DoesNotThrow(_testObj.Play);
        }

        [Test]
        public void TestUiUpdatesWhenGamePlayed()
        {
            SetupGame();
            _testObj.Play();
            Assert.That(_ui.UiUpdated, Is.True);
        }

        [Test]
        public void TestGameOver()
        {
            SetupGame();
            _testObj.Play();
            Assert.That(_ui.GameOver, Is.True);
        }
    }

    internal class TestUi : IUi
    {
        public bool UiUpdated;
        public bool GameOver;

        public void EndGame()
        {
            GameOver = true;
        }

        public void Update()
        {
            UiUpdated = true;
        }
    }
}