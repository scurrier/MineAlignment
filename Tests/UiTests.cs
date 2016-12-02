using System.IO;
using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class UiTests
    {
        [Test]
        public void DrawsEmptyBoard()
        {
            DrawsCellsForBoard(new Board(0,0));
        }

        [Test]
        public void DrawsOneByOne()
        {
            DrawsCellsForBoard(new Board(1, 1), Cell(0, 0));
        }
        
        [Test]
        public void DrawsOneByTwo()
        {
            DrawsCellsForBoard(new Board(1, 2), Cell(0, 0), Cell(0, 1));            
        }

        [Test]
        public void DrawsTwoByOne()
        {
            DrawsCellsForBoard(new Board(2, 1), Cell(0, 0), Cell(1, 0));
        }
       
        private static Cell Cell(int row, int column)
        {
            return new Cell(row, column);
        }

        private static void DrawsCellsForBoard(Board board, params Cell[] enumerable)
        {
            var testObj = new TestableUi();
            testObj.DrawBoard(board);
            Assert.That(testObj.PrintedCells, Is.EquivalentTo(enumerable));
        }
    }
}