namespace LeetCode
{
    using System.Collections.Generic;

    public class PascalTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            ++rowIndex;

            if (rowIndex < 1)
            {
                return new List<int>();
            }

            var result = new List<int>();
            for (var i = 0; i < rowIndex; ++i)
            {
                result.Add(0);
            }

            for (var i = 1; i <= rowIndex; ++i)
            {
                for (var j = i - 1; j >= 0; --j)
                {
                    if (j == 0 || j == i - 1)
                    {
                        result[j] = 1;
                    }
                    else
                    {
                        result[j] = result[j] + result[j - 1];
                    }
                }
            }

            return result;
        }
    }
}