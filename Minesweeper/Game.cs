using System;

namespace Minesweeper
{
    public  class Game
    {
        private Ui _ui;
        private readonly Board _board;

        public Game(int rows, int columns)
        {
            _board = new Board(rows, columns);
            OverrideUi(new ConsoleUi());
        }

        public static Game Create(int rows, int columns)
        {
            return new Game(rows, columns);

        }

        public void Play()
        {
            _ui.Refresh();
            _ui.GameOver();
        }

        internal void OverrideUi(Ui ui)
        {
            _ui = ui;
            ui.SetBoard(_board);
        }
    }

    public class Board
    {
        public int Rows { get; }
        public int Columns { get; }

        public Board(int rows, int cols)
        {
            Rows = rows;
            Columns = cols;
        }
        
        public void VisitCells(Action<Cell> updateCell)
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    updateCell(new Cell(i, j));
        }
    }
}