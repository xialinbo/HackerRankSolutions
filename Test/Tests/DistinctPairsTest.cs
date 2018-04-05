using NUnit.Framework;
using Solution.Solutions;

namespace Test.Tests
{
    public class DistinctPairsTest
    {
        [Test]
        public void VerifyWithSimpleCase()
        {
            var a = new[] { 7, 6, 6, 3, 9, 3, 5, 1 };
            var k = 12;
            var result = new DistinctPairs().NumberOfPairs(a, k);

            Assert.AreEqual(3, result);
        }
    }
}