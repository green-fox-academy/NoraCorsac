using NUnit.Framework;
using Sum;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Add([Values(1, 5, 8)] int x, [Values(2, 3, 9)] int y)
        {
            var program = new Program();
            int result = program.Add();
            Assert.AreEqual(5,result);
        }
    }
}
