namespace Minesweeper
{
    public class Game
    {
        private Ui _ui;
        private Board _board;

        public Game()
        {
            _board = new Board();
            var ui = new ConsoleUi();
            SetUi(ui);
        }

        public static Game Create(int rows, int columns)
        {
            return new Game();
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