namespace Minesweeper
{
    public abstract class Ui
    {
        public abstract void Win();

        public virtual void DrawBoard(Board board)
        {
            var numberOfCells = board.Rows * board.Columns;
            for (var i = 0; i < numberOfCells; i++)
                PrintCell(board.GetCell(0,0));
        }

        protected abstract void PrintCell(Cell cell);
    }
}