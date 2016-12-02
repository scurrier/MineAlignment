using System.Collections.Generic;
using Minesweeper;

namespace Tests
{
    internal class TestableUi : Ui
    {
        public override void Win()
        {
            
        }

        protected override void PrintCell(Cell cell)
        {
            CellsPrinted++;
            PrintedCells.Add(cell);
        }

        public int CellsPrinted { get; private set; }

        public ICollection<Cell> PrintedCells { get; } = new List<Cell>();
    }
}