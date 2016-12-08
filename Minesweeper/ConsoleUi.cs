using System;

namespace Minesweeper
{
    internal class ConsoleUi : Ui
    {
        public override void GameOver()
        {
            Console.WriteLine("Game over, dude!");
        }
    }
}