using System;

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

        public void CollectCells(Action<Cell> collector)
        {
            for(var row = 0; row < Rows; row++)
            for(var col = 0; col < Columns; col++)
                    collector(new Cell(row, col));
        }
    }
}