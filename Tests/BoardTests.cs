using System.Collections.Generic;
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

        [Test]
        public void CollectCellsCallsActionWithCells()
        {
            var testObj = new Board(3, 2);
            var cells = new List<Cell>();
            testObj.CollectCells(c => { cells.Add(c); });
            CollectionAssert.AreEquivalent(new List<Cell>
            {
                new Cell(0, 0),
                new Cell(1, 0),
                new Cell(2, 0),
                new Cell(0, 1),
                new Cell(1, 1),
                new Cell(2, 1),
            }, cells);
        }
    }
}