using System;

namespace Minesweeper
{
    public class ConsoleUi : Ui
    {
        public override void EndGame()
        {
            Console.WriteLine("Game over.");
        }
        
        internal override void UpdateCell(Cell cell)
        {
        }
    }
}