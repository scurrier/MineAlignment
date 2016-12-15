using System.Security.Policy;
using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestTest
    {
        [Test]
        public void TestCreate()
        {
            Game testObj = Game.Create(0, 0);
            Assert.DoesNotThrow(testObj.Play);
        }
    }
}
