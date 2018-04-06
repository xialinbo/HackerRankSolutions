using NUnit.Framework;
using Solution.Solutions;

namespace Test.Tests
{
    public class MaximumDifferenceInArrayTest
    {
        [Test]
        public void VerifyWithSimpleCase()
        {
            var array = new[] {2, 3, 10, 2, 4, 8, 1};
            var result = new MaximumDifferenceInArray().GetMaxDifference(array);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void VerifyWithSpecialCase()
        {
            var array = new[] { 10, 8, 7, 6, 5 };
            var result = new MaximumDifferenceInArray().GetMaxDifference(array);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void VerifyWithLargeCase()
        {
            var array = new[] { 948651, 948301, 943568, 935306, 925753, 925097, 909070, 897989, 895462, 894942, 867766, 836568, 817708, 805234, 781684, 777763, 757724, 753489, 741693, 735074, 711442, 676369, 655548, 650297, 627692, 610997, 610251, 610197, 580165, 570798, 569460, 545032, 530137, 513952, 432957, 410455, 405671, 402765, 393891, 377172, 296068, 286588, 271415, 231069, 212854, 209511, 197945, 185689, 176258, 165907, 138205, 119136, 91500, 78455, 78001, 59155, 31824, 29784, 1807 };
            var result = new MaximumDifferenceInArray().GetMaxDifference(array);

            Assert.AreEqual(-1, result);
        }
    }
}