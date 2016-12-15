using System;

namespace Minesweeper
{
    public class Board
    {
        private readonly int _rows;
        private readonly int _columns;

        public Board(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
        }

        public void CollectCells(Action<Cell> collector)
        {
            for(var row = 0; row < _rows; row++)
            for(var col = 0; col < _columns; col++)
                    collector(new Cell(row, col));
        }
    }
}