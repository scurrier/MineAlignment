namespace Minesweeper
{
    public  class Game
    {
        private Ui _ui = new ConsoleUi();

        public static Game Create(int rows, int columns)
        {
            return new Game();
        }

        public void Play()
        {
            _ui.GameOver();
        }

        internal void OverrideUi(Ui ui)
        {
            _ui = ui;
        }
    }
}