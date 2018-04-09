using NUnit.Framework;
using Solution.Solutions;

namespace Test.Tests
{
    public class MatrixPathTest
    {
        [Test]
        public void VerifyWithSimpleCase()
        {
            var matrix = new[]
            {
                new[] { 1, 1, 1, 1 },
                new[] { 1, 1, 1, 1 },
                new[] { 1, 1, 1, 1 }
            };

            var result = new MatrixPath().GetNumberOfPaths(matrix);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void VerifyWithSpecialCase()
        {
            var matrix = new[]
            {
                new[] { 1, 1, 0, 1 },
                new[] { 1, 1, 1, 1 }
            };

            var result = new MatrixPath().GetNumberOfPaths(matrix);
            Assert.AreEqual(2, result);
        }
    }
}