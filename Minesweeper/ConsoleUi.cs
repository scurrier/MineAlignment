using System;

namespace Minesweeper
{
    internal class ConsoleUi : Ui
    {
        public override void GameOver()
        {
            Console.WriteLine("\n\nGame over, dude!");
        }

        public override void UpdateCell(Cell cell)
        {
            Console.SetCursorPosition(cell.Col, cell.Row);
            Console.Write("#");
        }
    }
}