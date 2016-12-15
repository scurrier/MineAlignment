using System.Security.Policy;
using Minesweeper;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestTest
    {
        private Game _testObj;
        private TestUi _ui;

        [SetUp]
        public void SetUp()
        {
            _ui = new TestUi();
        }

        [Test]
        public void TestCreate()
        {
            _testObj = Game.Create(0, 0);
            Assert.DoesNotThrow(_testObj.Play);
        }

        [Test]
        public void TestGameOver()
        {
            _testObj = Game.Create(0, 0);
            _testObj.SetUi(_ui);
            _testObj.Play();
            Assert.That(_ui.GameOver, Is.True);
        }
    }

    internal class TestUi : IUi
    {
        public bool GameOver { get; set; }
        public void EndGame()
        {
            GameOver = true;
        }
    }
}
