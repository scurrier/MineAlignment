namespace Minesweeper
{
    public abstract class Ui
    {
        protected Board _board;
        public abstract void GameOver();

        public void Refresh(Board board)
        {
            board.VisitCells(UpdateCell);
        }

        public abstract void UpdateCell(Cell cell);

        public void SetBoard(Board board)
        {
            _board = board;
        }
    }
}