using Minesweeper;

namespace Tests
{
    internal class TestableUi : Ui
    {
        public override void Win()
        {
            
        }

        protected override void PrintCell()
        {
            CellsPrinted++;
        }

        public int CellsPrinted { get; private set; }
    }
}