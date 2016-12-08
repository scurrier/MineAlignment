using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void TestPlay()
        {
            var testObj = Game.Create(0, 0);
            Assert.DoesNotThrow(testObj.Play);
        }
    }
}