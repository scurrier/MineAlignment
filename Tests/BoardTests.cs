using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    internal class BoardTests
    {
        [Test]
        public void CollectCellsCallsActionBasedOnBoardSize()
        {
            var testObj = new Board(4, 5);
            int called = 0;
            testObj.CollectCells(c => { called++; });
            Assert.That(called, Is.EqualTo(20));
        }
    }
}