using System;

namespace Minesweeper
{
    public class ConsoleUi : IUi
    {
        public void EndGame()
        {
            Console.WriteLine("Game over.");
        }
    }
}