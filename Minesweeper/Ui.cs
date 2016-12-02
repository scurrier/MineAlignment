namespace Minesweeper
{
    public abstract class Ui
    {
        public abstract void Win();

        public virtual void DrawBoard(Board board)
        {
            var numberOfCells = board._rows * board._columns;
            for(var i =0; i <numberOfCells ;i++)
                PrintCell();
        }

        protected abstract void PrintCell();
    }
}