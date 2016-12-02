namespace Minesweeper
{
    public abstract class Ui
    {
        public abstract void Win();

        public virtual void DrawBoard(Board board)
        {
            for(var row = 0; row<board.Rows;row++)
                for (var column = 0; column < board.Columns; column++)
                    PrintCell(board.GetCell(row,column));
        }

        protected abstract void PrintCell(Cell cell);
    }
}