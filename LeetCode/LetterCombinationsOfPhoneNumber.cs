using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LetterCombinationsOfPhoneNumber
    {
        private string[] mapping = new string[]
                                       {
                                           " ",
                                           "",
                                           "abc",
                                           "def",
                                           "ghi",
                                           "jkl",
                                           "mno",
                                           "pqrs",
                                           "tuv",
                                           "wxyz"
                                       };

        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();

            if (digits.Length == 0)
            {
                return result;
            }

            int length = digits.Length;

            StringBuilder sb = new StringBuilder();
            char[] emptyChars = new char[length];
            sb.Append(emptyChars);

            this.GenerateStr(sb, 0, result, digits);

            return result;
        }

        private void GenerateStr(StringBuilder sb, int v, IList<string> result, string digits)
        {
            if (v == digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            string letters = this.mapping[digits[v] - '0'];
            foreach (char t in letters)
            {
                sb[v] = t;

                this.GenerateStr(sb, v + 1, result, digits);
            }
        }
    }
}
