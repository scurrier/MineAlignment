using System;

namespace Minesweeper
{
    public  class Game
    {
        private Ui _ui = new ConsoleUi();
        private readonly Board _board;

        public Game(int rows, int columns)
        {
            _board = new Board(rows, columns);
        }

        public static Game Create(int rows, int columns)
        {
            return new Game(rows, columns);

        }

        public void Play()
        {
            _ui.Refresh(_board);
            _ui.GameOver();
        }

        internal void OverrideUi(Ui ui)
        {
            _ui = ui;
        }
    }

    public class Board
    {
        private readonly int _rows;
        private readonly int _cols;

        public Board(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
        }

        public void VisitCells(Action<Cell> updateCell)
        {
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                    updateCell(new Cell(i, j));
        }
    }
}