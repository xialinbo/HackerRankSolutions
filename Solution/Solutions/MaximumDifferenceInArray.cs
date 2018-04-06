using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.Solutions
{
    public class MaximumDifferenceInArray
    {
        public int GetMaxDifference(int[] numbers)
        {
            var count = numbers.Length;
            var minNumberArray = new int[count];
            var maxNumberArray = new int[count];

            minNumberArray[0] = numbers[0];
            for (int i = 1; i < count; i++)
            {
                minNumberArray[i] = Math.Min(numbers[i], minNumberArray[i - 1]);
            }

            maxNumberArray[count - 1] = numbers[count - 1];
            for (int i = count - 2; i >= 0; i--)
            {
                maxNumberArray[i] = Math.Max(numbers[i], maxNumberArray[i + 1]);
            }

            var differences = new List<int>();
            for (int i = 0; i < count; i++)
            {
                differences.Add(maxNumberArray[i]-minNumberArray[i]);
            }

            var result = differences.Max();

            return result > 0 ? result : -1;
        }
    }
}