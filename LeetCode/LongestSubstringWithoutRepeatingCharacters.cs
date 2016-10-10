using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }

            int maxLength = 0;

            int p = 0, q = 0;

            IDictionary<char, int> usedChars = new Dictionary<char, int>();

            while (q < s.Length)
            {
                var c = s[q];
                if (usedChars.ContainsKey(c))
                {
                    var oldIndex = usedChars[c];

                    for (int i = p; i <= oldIndex; i++)
                    {
                        usedChars.Remove(s[i]);
                    }

                    usedChars.Add(c, q);
                    p = oldIndex + 1;
                }
                else
                {
                    usedChars.Add(c, q);
                }

                ++q;
                maxLength = Math.Max(maxLength, q - p);
            }

            return maxLength;
        }
    }
}
