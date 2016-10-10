using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int p = 1;
            while (x / p >= 10)
            {
                p *= 10;
            }

            while (x > 0) 
            {
                if (x / p != x % 10)
                {
                    return false;
                }

                x -= (x % 10) * p;
                x /= 10;
                p /= 100;
            }

            return true;
        }
    }
}
