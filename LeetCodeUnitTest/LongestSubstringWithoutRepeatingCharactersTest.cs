using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        private LongestSubstringWithoutRepeatingCharacters util = new LongestSubstringWithoutRepeatingCharacters();

        [TestMethod]
        public void TestSimple()
        {
           Assert.AreEqual(3, this.util.LengthOfLongestSubstring("abcabcbb"));
           Assert.AreEqual(4, this.util.LengthOfLongestSubstring("abcabcdbb"));
           Assert.AreEqual(1, this.util.LengthOfLongestSubstring("bbbbb"));
           Assert.AreEqual(3, this.util.LengthOfLongestSubstring("pwwkew"));
           Assert.AreEqual(1, this.util.LengthOfLongestSubstring("c"));
           Assert.AreEqual(1, this.util.LengthOfLongestSubstring("cc"));
           Assert.AreEqual(2, this.util.LengthOfLongestSubstring("ca"));
        }
    }
}
