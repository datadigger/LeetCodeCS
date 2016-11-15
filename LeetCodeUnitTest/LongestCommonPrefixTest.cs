using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTest
{
    using LeetCode;

    using NUnit.Framework;

    [TestFixture]
    public class LongestCommonPrefixTest
    {
        private readonly LongestCommonPrefix util = new LongestCommonPrefix();

        [Test]
        public void TestSimple()
        {
            Assert.That("aaa", Is.EqualTo(this.util.DoSearch(new string[] {"aaaa", "aaab", "aaa", "aaac"})));
            Assert.That(string.Empty, Is.EqualTo(this.util.DoSearch(new string[] {"a", "b"})));
            Assert.That("abc", Is.EqualTo(this.util.DoSearch(new string[] { "abc"})));

            Assert.That(string.Empty, Is.EqualTo(this.util.DoSearch(new string[] {})));
        }
    }
}
