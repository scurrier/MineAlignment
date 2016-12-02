namespace Minesweeper
{
    public class Board
    {
        public readonly int Rows;
        public readonly int Columns;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public Cell GetCell(int row, int column)
        {
            return new Cell(row, column);
        }
    }
}