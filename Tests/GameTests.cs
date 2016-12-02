using Minesweeper;
using NUnit.Framework;

namespace Tests

{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void GameCanBePlayed()
        {
            var game = Game.Create(0, 0);
            Assert.DoesNotThrow(() => game.Play());
        }
    }
}