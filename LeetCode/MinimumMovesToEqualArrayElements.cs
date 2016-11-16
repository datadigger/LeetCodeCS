using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MinimumMovesToEqualArrayElements
    {
        public int MinMoves(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            var min = nums[0];

            for (int i = 1; i < nums.Length; ++i)
            {
                min = Math.Min(min, nums[i]);
            }

            var sum = 0;
            foreach (var num in nums)
            {
                sum += (num - min);
            }

            return sum;
        }
    }
}
