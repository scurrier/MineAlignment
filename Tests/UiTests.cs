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
            var testObj = new TestableUi();
            testObj.DrawBoard(new Board(0, 0));
            Assert.That(testObj.CellsPrinted, Is.EqualTo(0));
        }

        [Test]
        public void DrawsBoard()
        {
            var testObj = new TestableUi();
            testObj.DrawBoard(new Board(4,3));
            Assert.That(testObj.CellsPrinted, Is.EqualTo(12));
        }
    }
}