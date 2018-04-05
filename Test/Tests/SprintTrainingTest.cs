using NUnit.Framework;
using Solution.Solutions;

namespace Test.Tests
{
    public class SprintTrainingTest
    {
        [Test]
        public void VerifyWithSimpleCase()
        {
            var sprints = new[] { 1, 5, 10, 3 };
            var result = new SprintTraining().GetMostVisited(10, sprints);

            Assert.AreEqual(5, result);
        }
    }
}
