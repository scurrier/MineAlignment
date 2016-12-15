namespace Minesweeper
{
    public class Game
    {
        private IUi _ui;

        public Game()
        {
            SetUi(new ConsoleUi());
        }
        public static Game Create(int rows, int columns)
        {
            return new Game();
        }

        public void Play()
        {
            _ui.EndGame();
        }

        internal void SetUi(IUi ui)
        {
            _ui = ui;
        }
    }
}