namespace Minesweeper
{
    public abstract class Ui
    {
        public abstract void GameOver();

        public void Refresh(Board board)
        {
            board.VisitCells(UpdateCell);
        }

        public abstract void UpdateCell(Cell cell);

    }
}