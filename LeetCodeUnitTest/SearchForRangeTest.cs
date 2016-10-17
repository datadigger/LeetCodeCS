using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    using LeetCode;

    /// <summary>
    /// Summary description for SearchForRangeTest
    /// </summary>
    [TestClass]
    public class SearchForRangeTest
    {
        private readonly SearchForRange util = new SearchForRange();

        [TestMethod]
        public void TestSimple()
        {
            Assert.AreEqual(new int[] {3, 4}, this.util.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8));
        }
    }
}
