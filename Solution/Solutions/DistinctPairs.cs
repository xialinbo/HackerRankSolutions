using System;

namespace Solution.Solutions
{
    public class DistinctPairs
    {
        public int NumberOfPairs(int[] numbers, long sum)
        {
            Array.Sort(numbers);
            var complement = new long[numbers.Length];
            for (int i = 0; i < complement.Length; i++)
            {
                complement[i] = sum - numbers[i];
            }

            var numberPointer = 0;
            var complementPointer = complement.Length - 1;
            var count = 0;

            while (numberPointer < complementPointer)
            {
                if (numbers[numberPointer] == complement[complementPointer])
                {
                    count++;
                }

                if (numbers[numberPointer] >= complement[complementPointer])
                {
                    do
                    {
                        complementPointer--;
                    }
                    while (complement[complementPointer] == complement[complementPointer + 1]);
                }
                else if (numbers[numberPointer] <= complement[complementPointer])
                {
                    do
                    {
                        numberPointer++;
                    }
                    while (numbers[numberPointer] == numbers[numberPointer - 1]);
                }
            }

            return count;
        }
    }
}