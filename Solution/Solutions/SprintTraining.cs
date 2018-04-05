using System;
using System.Collections.Generic;

namespace Solution.Solutions
{
    public class SprintTraining
    {
        public int GetMostVisited(int n, int[] sprints)
        {
            var incremental = new int[n + 2];
            for (int i = 0; i < sprints.Length - 1; i++)
            {
                var start = Math.Min(sprints[i], sprints[i + 1]);
                var end = Math.Max(sprints[i], sprints[i + 1]);
                incremental[start]++;
                incremental[end + 1]--;
            }

            var scores = new int[n + 1];
            var score = 0;
            for (int i = 1; i < n + 1; i++)
            {
                score += incremental[i];
                scores[i] = score;
            }

            var result = new KeyValuePair<int, int>(0, 0);
            for (int i = 1; i < n + 1; i++)
            {
                if (scores[i] > result.Value)
                {
                    result = new KeyValuePair<int, int>(i, scores[i]);
                }
            }
            return result.Key;
        }
    }
}
