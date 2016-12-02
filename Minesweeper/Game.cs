using System;

namespace Minesweeper
{
    public class Game
    {
        internal Ui Ui { set; private get; }

        public static Game Create(int i, int i1)
        {
            return new Game();
        }

        public void Play()
        {
            Ui.Win();
        }

        internal Game()
        {
            Ui = new Ui();
        }
    }

    internal class Ui
    {
        public virtual void Win()
        {
            Console.WriteLine("You win!");
        }
    }
}