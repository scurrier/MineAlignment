namespace Minesweeper
{
    public struct Cell
    {
        public int Row { get; }
        public int Column { get; }
        public char Content { get; }

        public Cell(int row, int column)
        {
            Row = row;
            Column = column;
            Content = '.';
        }

    }

    public class Game
    {
        internal Ui Ui { set; private get; }

        public static Game Create(int i, int i1)
        {
            return new Game();
        }

        public void Play()
        {
            Ui.DrawBoard(new Board(0, 0));
            Ui.Win();
        }

        internal Game()
        {
            Ui = new ConsoleUi();
        }
    }
}