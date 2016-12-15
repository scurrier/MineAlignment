using System;
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

        private void SetupGame(int rows = 0, int columns = 0)
        {
            _testObj = Game.Create(rows, columns);
            _testObj.SetUi(_ui);
        }

        [Test]
        public void SetUiSetsBoard()
        {
            _testObj = Game.Create(0, 0);
            _testObj.SetUi(_ui);
            Assert.That(_ui.HasBoard, Is.True);
        }

        [Test]
        public void TestCreate()
        {
            _testObj = Game.Create(0, 0);
            Assert.DoesNotThrow(_testObj.Play);
        }

        [Test]
        public void TestGameOver()
        {
            SetupGame();
            _testObj.Play();
            Assert.That(_ui.GameOver, Is.True);
        }

        [Test]
        public void TestUiUpdatesWhenGamePlayed()
        {
            SetupGame(2, 1);
            _testObj.Play();
            Assert.That(_ui.CellsUpdated, Is.EqualTo(2));
        }

    }

    internal class TestUi : Ui
    {
        public int CellsUpdated;
        public bool GameOver;

        public override void EndGame()
        {
            GameOver = true;
        }

        public bool HasBoard()
        {
            return Board != null;
        }

        internal override void UpdateCell(Cell cell)
        {
            CellsUpdated++;
        }
    }
}