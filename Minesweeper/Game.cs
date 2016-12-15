namespace Minesweeper
{
    public class Game
    {
        private Ui _ui;
        private readonly Board _board;

        private Game(Board board)
        {
            _board = board;
            var ui = new ConsoleUi();
            SetUi(ui);
        }

        public static Game Create(int rows, int columns)
        {
            return new Game(new Board(rows, columns));
        }

        public void Play()
        {
            _ui.Update();
            _ui.EndGame();
        }

        internal void SetUi(Ui ui)
        {
            _ui = ui;
            _ui.SetBoard(_board);
        }
    }
}