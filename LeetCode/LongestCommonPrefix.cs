using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefix
    {
        public string DoSearch(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var minLength = strs[0].Length;
            for (var i = 1; i < strs.Length; ++i)
            {
                minLength = Math.Min(minLength, strs[i].Length);
            }

            int prefixIndex = 0;

            for (; prefixIndex < minLength; ++prefixIndex)
            {
                var c = strs[0][prefixIndex];

                var isCommon = true;
                for (var i = 1; i < strs.Length; ++i)
                {
                    if (c != strs[i][prefixIndex])
                    {
                        isCommon = false;
                        break;
                    }
                }

                if (!isCommon)
                {
                    break;
                }
            }

            return strs[0].Substring(0, prefixIndex);
        }
    }
}