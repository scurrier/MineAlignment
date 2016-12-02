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
            Ui.DrawBoard(new Board(0,0));
            Ui.Win();
        }

        internal Game()
        {
            Ui = new ConsoleUi();
        }
    }

    internal class ConsoleUi : Ui
    {
        public override void Win()
        {
            Console.WriteLine("You Win!");
        }


        protected override void PrintCell()
        {
            
        }
}
}