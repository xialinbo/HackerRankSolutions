using System;
using System.Linq;

namespace Solution.Solutions
{
    public class MaximumDifferenceInArray
    {
        public int GetMaxDifference(int[] numbers)
        {
            var minNumber = numbers[0];
            var maxDiff = -1;

            foreach(var i in Enumerable.Range(1, numbers.Count() - 1))
            {
                minNumber = Math.Min(minNumber, numbers[i]);
                maxDiff = Math.Max(maxDiff, numbers[i] - minNumber);
            }

            return maxDiff > 0 ? maxDiff : -1;
        }
    }
}