namespace LeetCode
{
    using System.Collections.Generic;

    public class IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var aDict = new Dictionary<int, int>();

            foreach (var num in nums1)
            {
                if (aDict.ContainsKey(num))
                {
                    aDict[num] = aDict[num] + 1;
                }
                else
                {
                    aDict[num] = 1;
                }
            }

            var results = new List<int>();

            foreach (var num in nums2)
            {
                if (aDict.ContainsKey(num) && aDict[num] > 0)
                {
                    results.Add(num);
                    aDict[num] = aDict[num] - 1;
                }
            }

            return results.ToArray();
        }
    }
}