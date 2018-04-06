using System;
using System.Collections.Generic;

namespace Solution.Solutions
{
    public class SprintTraining
    {
        public int GetMostVisited(int markerCount, int[] sprints)
        {
            var incremental = new int[markerCount + 2];
            for (int i = 0; i < sprints.Length - 1; i++)
            {
                var start = Math.Min(sprints[i], sprints[i + 1]);
                var end = Math.Max(sprints[i], sprints[i + 1]);
                incremental[start]++;
                incremental[end + 1]--;
            }

            var scores = new int[markerCount + 1];
            var score = 0;
            for (int i = 1; i < markerCount + 1; i++)
            {
                score += incremental[i];
                scores[i] = score;
            }

            var result = new KeyValuePair<int, int>(0, 0);
            for (int i = 1; i < markerCount + 1; i++)
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
