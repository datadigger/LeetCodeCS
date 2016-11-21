namespace LeetCode
{
    public class UniquePathsUtil
    {
        public int UniquePaths(int m, int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }

            var sum = new int[m, n];

            for (var i = 0; i < m; ++i)
            {
                sum[i, 0] = 1;
            }

            for (var j = 0; j < n; ++j)
            {
                sum[0, j] = 1;
            }

            for (var i = 1; i < m; ++i)
            {
                for (var j = 1; j < n; ++j)
                {
                    sum[i, j] = sum[i, j - 1] + sum[i - 1, j];
                }
            }

            return sum[m - 1, n - 1];
        }
    }
}