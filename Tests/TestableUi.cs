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
            PrintedCells.Add(cell);
        }
        
        public ICollection<Cell> PrintedCells { get; } = new List<Cell>();
    }
}