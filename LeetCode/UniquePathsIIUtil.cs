namespace LeetCode
{
    using System;

    public class UniquePathsIIUtil
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            var m = obstacleGrid.GetUpperBound(0) + 1;
            var n = obstacleGrid.GetUpperBound(1) + 1;

            if (m == 0 || n == 0)
            {
                return 0;
            }

            var sum = new int[m, n];

            for (var i = 0; i < m; ++i)
            {
                for (var j = 0; j < n; ++j)
                {
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        sum[i, j] = obstacleGrid[i, j] == 1 ? 0 : sum[i - 1, j] + sum[i, j - 1];
                    }
                    else if (i - 1 >= 0)
                    {
                        sum[i, j] = obstacleGrid[i, j] == 1 ? 0 : sum[i - 1, j];
                    }
                    else if (j - 1 >= 0)
                    {
                        sum[i, j] = obstacleGrid[i, j] == 1 ? 0 : sum[i, j - 1];
                    }
                    else
                    {
                        sum[i, j] = obstacleGrid[i, j] == 1 ? 0 : 1;
                    }

                }
            }

            return sum[m - 1, n - 1];
        }
    }
}