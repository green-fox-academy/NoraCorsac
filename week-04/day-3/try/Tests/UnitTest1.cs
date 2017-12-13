using NUnit.Framework;
using ConsoleApp1;

namespace Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetApple()
        {
            Program p = new Program();
            var result = p.GetApple();
            Assert.AreEqual("apple", result);
        }
    }
}
