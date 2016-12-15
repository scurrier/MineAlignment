using System;

namespace Minesweeper
{
    public class ConsoleUi : Ui
    {
        public override void EndGame()
        {
            Console.SetCursorPosition(0, Board.Rows);
            Console.WriteLine("Game over.");
        }
        
        internal override void UpdateCell(Cell cell)
        {
            Console.SetCursorPosition(cell.Column, cell.Row);
            Console.Write(".");
        }
    }
}