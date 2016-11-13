using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddStringsUtil
    {
        public string AddStrings(string num1, string num2)
        {
            if (num1 == null || num2 == null)
            {
                return null;
            }

            var len1 = num1.Length;
            var len2 = num2.Length;

            var carry = 0;
            var len3 = Math.Max(len1, len2) + 1;

            var num3 = new int[len3];

            for (var i = 1; i <= len3; ++i)
            {
                var digit1 = i <= len1 ? num1[len1 - i] - '0' : 0;
                var digit2 = i <= len2 ? num2[len2 - i] - '0' : 0;

                var sum = digit1 + digit2 + carry;
                carry = sum / 10;

                num3[len3 - i] = sum % 10;
            }

            var sb = new StringBuilder();
            var headZeroSkipped = false;
            foreach (var num in num3)
            {
                if (num == 0 && !headZeroSkipped)
                {
                    continue;
                }

                headZeroSkipped = true;

                sb.Append(num);
            }

            return sb.Length == 0 ? "0" : sb.ToString();
        }
    }
}
