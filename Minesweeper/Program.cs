using System.Security.Policy;

namespace Minesweeper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game.Create(24, 70).Play();
        }
    }
}