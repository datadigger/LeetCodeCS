using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    using LeetCode;

    /// <summary>
    /// Summary description for ImplementStrStr
    /// </summary>
    [TestClass]
    public class ImplementStrStrTest
    {
        private readonly ImplementStrStr util = new ImplementStrStr();

        [TestMethod]
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
