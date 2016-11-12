using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Resolve the problem of multiple strings.
    /// </summary>
    public class MultiplyStrings
    {
        /// <summary>
        /// The multiply.
        /// </summary>
        /// <param name="num1">
        /// The number 1.
        /// </param>
        /// <param name="num2">
        /// The number 2.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Multiply(string num1, string num2)
        {
            if (num1 == null || num2 == null)
            {
                return null;
            }

            int len1 = num1.Length, len2 = num2.Length;
            var len3 = len1 + len2;

            var num3 = new int[len3];
            var index = len3 - 1;
            var carry = 0;

            for (int i = len1 - 1; i >= 0; --i)
            {
                var offset = 0;
                for (int j = len2 - 1; j >=0; --j)
                {
                    var multiply = (int)Char.GetNumericValue(num1[i]) * (int)Char.GetNumericValue(num2[j]);

                    var sum = multiply + carry + num3[index - offset];
                    var mod = sum % 10;
                    carry = sum / 10;


                    num3[index - offset] = mod;

                    ++offset;
                }

                if (carry > 0)
                {
                    num3[index - offset] = carry;
                    carry = 0;
                }

                --index;
            }

            if (carry > 0)
            {
                num3[index] = carry;
            }

            var sb = new StringBuilder();
            var skipHeadZero = false;
            foreach (var t in num3)
            {
                if (t == 0 && !skipHeadZero)
                {
                    continue;
                }

                skipHeadZero = true;

                sb.Append(t.ToString());
            }

            var result = sb.ToString();
            return result.Length == 0 ? "0" : sb.ToString();
        }
    }
}
