using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTest
{
    using LeetCode;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AddStringUtilTest
    {
        private readonly AddStringsUtil util = new AddStringsUtil();

        [TestMethod]
        public void TestSimple()
        {
            Assert.AreEqual("123", this.util.AddStrings("123", "0"));
            Assert.AreEqual("0", this.util.AddStrings("0", "0"));
            Assert.AreEqual("10", this.util.AddStrings("1", "9"));
            Assert.AreEqual("10000000", this.util.AddStrings("10000000", "0"));
            Assert.AreEqual("29", this.util.AddStrings("21", "8"));
        }
    }
}