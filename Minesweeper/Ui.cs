namespace Minesweeper
{
    public abstract class Ui
    {
        protected Board Board;
        public abstract void EndGame();

        public void Update()
        {
            Board.CollectCells(UpdateCell);
        }

        internal abstract void UpdateCell(Cell cell);
        public void SetBoard(Board board)
        {
            Board = board;
        }
    }
}