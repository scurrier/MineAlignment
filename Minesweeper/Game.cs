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
        private readonly int _rowSize;
        private readonly int _columnSize;
        internal Ui Ui { set; private get; }

        public static Game Create(int rowSize, int columnSize)
        {
            return new Game(rowSize, columnSize);
        }

        public void Play()
        {
            Ui.DrawBoard(new Board(_rowSize, _columnSize));
            Ui.Win();
        }

        internal Game(int rowSize, int columnSize)
        {
            _rowSize = rowSize;
            _columnSize = columnSize;
            Ui = new ConsoleUi();
        }
    }
}