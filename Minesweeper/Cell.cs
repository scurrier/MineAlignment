namespace Minesweeper
{
    public struct Cell
    {
        private int _col;
        private int _row;

        public Cell(int row, int col)
        {
            _row = row;
            _col = col;
        }
    }
}