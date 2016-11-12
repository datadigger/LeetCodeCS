using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    using LeetCode;

    using NUnit.Framework;

    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    /// <summary>
    /// Summary description for ImplementStrStr
    /// </summary>
    [TestFixture]
    public class ImplementStrStrTest
    {
        private readonly ImplementStrStr util = new ImplementStrStr();

        [Test]
        public void TestSimple()
        {
            Assert.AreEqual(0, this.util.StrStr("a", "a"));
            Assert.AreEqual(-1, this.util.StrStr("a", "b"));
            Assert.AreEqual(2, this.util.StrStr("abcc", "c"));
            Assert.AreEqual(0, this.util.StrStr("", ""));
            Assert.AreEqual(-1, this.util.StrStr("aaa", "aaaa"));
        }
    }
}
