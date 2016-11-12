using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    using LeetCode;

    /// <summary>
    /// Summary description for MultiplyStringsTest
    /// </summary>
    [TestClass]
    public class MultiplyStringsTest
    {
        private readonly MultiplyStrings util = new MultiplyStrings();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("1", this.util.Multiply("1", "1"));
            Assert.AreEqual("0", this.util.Multiply("0", "0"));
            Assert.AreEqual("4", this.util.Multiply("2", "2"));
            Assert.AreEqual("81", this.util.Multiply("9", "9"));
            Assert.AreEqual("121", this.util.Multiply("11", "11"));
            Assert.AreEqual("891", this.util.Multiply("9", "99"));
            Assert.AreEqual("98765431112345679", this.util.Multiply("987654321", "99999999"));
            Assert.AreEqual("1", this.util.Multiply("1", "1"));
            Assert.AreEqual("1", this.util.Multiply("1", "1"));
            Assert.AreEqual("10000", this.util.Multiply("10", "1000"));
            Assert.AreEqual("10000", this.util.Multiply("100", "100"));
            Assert.AreEqual("1234567654321", this.util.Multiply("1111111", "1111111"));
        }
    }
}
