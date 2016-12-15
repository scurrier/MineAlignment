namespace Minesweeper
{
    public class Game
    {
        private Ui _ui;
        private Board _board;

        private Game(int rows, int columns)
        {
            _board = new Board(rows, columns);
            var ui = new ConsoleUi();
            SetUi(ui);
        }

        public static Game Create(int rows, int columns)
        {
            return new Game(rows, columns);
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