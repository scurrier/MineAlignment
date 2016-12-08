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
            _testUi = new TestUi();
        }

        private TestUi _testUi;
        private Game _testObj;

        private void CreateTestObj(int rows, int columns)
        {
            _testObj = Game.Create(rows, columns);
            _testObj.OverrideUi(_testUi);
        }

        [Test]
        public void CanDisplayBoard()
        {
            CreateTestObj(2, 1);
            _testObj.Play();
            Assert.That(_testUi.CellsDisplayed, Is.EqualTo(2));
        }

        [Test]
        public void CanFinishGame()
        {
            CreateTestObj(0, 0);
            _testObj.Play();
            Assert.That(_testUi.GameFinished, Is.True);
        }

        [Test]
        public void TestPlay()
        {
            var testObj = Game.Create(0, 0);
            Assert.DoesNotThrow(testObj.Play);
        }

        [Test]
        public void TestUiSetup()
        {
            CreateTestObj(4, 5);
            Assert.That(_testUi.GetBoard().Rows, Is.EqualTo(4));
            Assert.That(_testUi.GetBoard().Columns, Is.EqualTo(5));
        }
    }

    internal class TestUi : Ui
    {
        public int CellsDisplayed;
        public bool GameFinished;
        public int InitializedCols = -1;
        public int InitializedRows = -1;

        public override void GameOver()
        {
            GameFinished = true;
        }

        public override void UpdateCell(Cell cell)
        {
            CellsDisplayed++;
        }

        public Board GetBoard()
        {
            return _board;
        }
    }
}