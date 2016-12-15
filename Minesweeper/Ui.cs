namespace Minesweeper
{
    public abstract class Ui
    {
        protected Board Board;
        public abstract void EndGame();
        public abstract void Update();

        public void SetBoard(Board board)
        {
            Board = board;
        }
    }
}