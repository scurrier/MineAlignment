using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        private TestUi _testUi = new TestUi();

        [Test]
        public void TestPlay()
        {
            var testObj = Game.Create(0, 0);
            Assert.DoesNotThrow(testObj.Play);
        }

        [Test]
        public void CanFinishGame()
        {
            var testObj = Game.Create(0, 0);
            testObj.OverrideUi(_testUi);
            testObj.Play();
            Assert.That(_testUi.GameFinished, Is.True);
        }
    }

    internal class TestUi : Ui
    {
        public bool GameFinished = false;
        public override void GameOver()
        {
            GameFinished = true;
        }
    }
}