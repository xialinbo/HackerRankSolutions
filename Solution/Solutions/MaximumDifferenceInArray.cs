using System.Collections.Generic;
using System.Linq;

namespace Solution.Solutions
{
    public class MaximumDifferenceInArray
    {
        public int GetMaxDifference(int[] numbers)
        {
            var numberDistibution = new SortedDictionary<int, List<int>>();
            for(int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (!numberDistibution.ContainsKey(number))
                {
                    numberDistibution[number] = new List<int>();
                }

                numberDistibution[number].Add(i);
            }

            var minPointer = 0;
            var maxPointer = numberDistibution.Count - 1;

            var minPointerUpperLimit = minPointer;
            var maxPointerLowerLimit = maxPointer;

            while (!IsAValidAnswer(numberDistibution, minPointerUpperLimit, maxPointer) && minPointerUpperLimit < maxPointer)
            {
                minPointerUpperLimit++;
            }

            while (!IsAValidAnswer(numberDistibution, minPointer, maxPointerLowerLimit) && maxPointerLowerLimit > minPointer)
            {
                maxPointerLowerLimit--;
            }

            var result = new List<int>();
            for (int i = minPointer; i <= minPointerUpperLimit; i++)
            {
                for (int j = maxPointer; j >= maxPointerLowerLimit; j--)
                {
                    var diff = numberDistibution.ElementAt(j).Key -
                               numberDistibution.ElementAt(i).Key;

                    if (IsAValidAnswer(numberDistibution, i, j))
                    {
                        result.Add(diff);
                    }
                }
            }

            return result.Max() > 0 ? result.Max() : -1;
        }

        private bool IsAValidAnswer(SortedDictionary<int, List<int>> numberDistibution, int minPointer, int maxPointer)
        {
            var indexListMin = numberDistibution.ElementAt(minPointer).Value;
            var indexListMax = numberDistibution.ElementAt(maxPointer).Value;

            return indexListMin.Min() < indexListMax.Max();
        }
    }
}