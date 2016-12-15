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
            for(var i = 0; i < _rows*_columns; i++)
                collector(null);
        }
    }
}