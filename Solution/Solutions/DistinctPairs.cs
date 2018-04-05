using System;

namespace Solution.Solutions
{
    public class DistinctPairs
    {
        public int NumberOfPairs(int[] a, long k)
        {
            Array.Sort(a);
            var b = new long[a.Length];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = k - a[i];
            }

            var aPointer = 0;
            var bPointer = b.Length - 1;
            var count = 0;

            while (aPointer < bPointer)
            {
                if (a[aPointer] == b[bPointer])
                {
                    count++;
                }

                if (a[aPointer] >= b[bPointer])
                {
                    do
                    {
                        bPointer--;
                    }
                    while (b[bPointer] == b[bPointer + 1]);
                }
                else if (a[aPointer] <= b[bPointer])
                {
                    do
                    {
                        aPointer++;
                    }
                    while (a[aPointer] == a[aPointer - 1]);
                }
            }

            return count;
        }
    }
}