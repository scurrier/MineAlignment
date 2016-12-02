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
            public bool BoardDrawn { get; private set; }

            public override void Win()
            {
                HasEnded = true;
            }

            public override void DrawBoard(Board board)
            {
                BoardDrawn = true;
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
            _testObj = Game.Create(0, 0);
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
            _testObj.Play();
            Assert.That(_testObjUi.BoardDrawn);
        }
    }
}