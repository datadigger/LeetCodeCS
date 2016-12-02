namespace LeetCode
{
    using System.Collections.Generic;

    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var results = new List<IList<int>>();

            for (var i = 1; i <= numRows; ++i)
            {
                var aList = new List<int>();

                for (var j = 0; j < i; ++j)
                {
                    if (j == 0 || j == i - 1)
                    {
                        aList.Add(1);
                    }
                    else
                    {
                        var previous = results[i - 1 - 1];
                        aList.Add(previous[j - 1] + previous[j]);
                    }
                }

                results.Add(aList);
            }

            return results;
        }
    }
}