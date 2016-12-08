using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        private class FakeUi : Ui
        {
            public bool HasEnded { get; private set; }
            public Board LastBoard { get; set; }

            public override void Win()
            {
                HasEnded = true;
            }

            public override void DrawBoard(Board board)
            {
                LastBoard = board;
            }


            protected override void PrintCell(Cell cell)
            {
                
            }
        }
        
        private Game _testObj;
        private FakeUi _testObjUi;

        [SetUp]
        public void SetUp()
        {
            var rowSize = 0;
            var columnSize = 0;
            buildTestObj(rowSize, columnSize);
        }

        private void buildTestObj(int rowSize, int columnSize)
        {
            _testObj = Game.Create(rowSize, columnSize);
            _testObjUi = new FakeUi();
            _testObj.Ui = _testObjUi;
        }

        [Test]
        public void RealGameCanBePlayed()
        {
            Assert.DoesNotThrow(() => Game.Create(0, 0).Play());
        }

        [Test]
        public void GameEnds()
        {
            _testObj.Play();
            Assert.True(_testObjUi.HasEnded);
        }

        [Test]
        public void PlayDrawsBoardBeforeGameEnd()
        {
            var rowSize = 2;
            var columnSize = 3;
            buildTestObj(rowSize,columnSize);
            _testObj.Play();
            Assert.That(_testObjUi.LastBoard.Rows, Is.EqualTo(rowSize));
            Assert.That(_testObjUi.LastBoard.Columns, Is.EqualTo(columnSize));
        }
    }
}