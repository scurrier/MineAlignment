using Minesweeper;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        private TestUi _testUi;

        [SetUp]
        public void SetUp()
        {
            _testUi = new TestUi();
        }


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

        [Test]
        public void CanDisplayBoard()
        {
            var testObj = Game.Create(2, 1);
            testObj.OverrideUi(_testUi);
            testObj.Play();
            Assert.That(_testUi.CellsDisplayed, Is.EqualTo(2));
        }
    }

    internal class TestUi : Ui
    {
        public bool GameFinished = false;
        public int CellsDisplayed = 0;

        public override void GameOver()
        {
            GameFinished = true;
        }

        public override void UpdateCell(Cell cell)
        {
            CellsDisplayed++;
        }
    }
}