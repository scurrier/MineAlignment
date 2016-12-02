using System;

namespace Minesweeper
{
    internal class ConsoleUi : Ui
    {
        public override void Win()
        {
            Console.WriteLine("You Win!");
        }


        protected override void PrintCell(Cell cell)
        {
            Console.SetCursorPosition(cell.Column, cell.Row);
            Console.Write(cell.Content);
        }
    }
}