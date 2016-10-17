using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    bool matched = true;
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (i + j >= haystack.Length)
                        {
                            matched = false;
                            break;
                        }

                        if (haystack[i + j] != needle[j])
                        {
                            matched = false;
                            break;
                        }
                    }

                    if (matched)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
