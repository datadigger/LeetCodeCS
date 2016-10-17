using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int li = 0, ri = height.Length - 1;

            int ans = (ri - li) * Math.Min(height[li], height[ri]);

            while (li < ri)
            {
                if (height[li] < height[ri])
                {
                    ++li;
                }
                else
                {
                    --ri;
                }

                ans = Math.Max(ans, (ri - li) * Math.Min(height[li], height[ri]));
            }


            return ans;
        }
    }
}
