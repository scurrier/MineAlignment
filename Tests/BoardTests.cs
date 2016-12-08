using System.Collections.Generic;
using System.Linq;
using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class BoardTests
    {
        private List<Cell> _cells = new List<Cell>();

        [Test]
        public void CanDisplayBoard()
        {
            var testObj = new Board(2, 1);
            testObj.VisitCells(RecordCell);
            Assert.That(_cells, Is.EquivalentTo(new Cell[] {new Cell(0,0), new Cell(1,0)}));
        }

        private void RecordCell(Cell cell)
        {
            _cells.Add(cell);
        }
    }
}