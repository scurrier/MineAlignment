using System;

namespace Minesweeper
{
    internal class ConsoleUi : Ui
    {
        public override void Win()
        {
            Console.WriteLine("You Win!");
        }


        protected override void PrintCell(char content, int row, int column)
        {
            Console.SetCursorPosition(column, row);
            Console.Write(content);
        }
    }
}