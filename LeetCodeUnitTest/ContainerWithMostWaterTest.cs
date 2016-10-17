using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    using LeetCode;

    /// <summary>
    /// Summary description for ContainerWithMostWaterTest
    /// </summary>
    [TestClass]
    public class ContainerWithMostWaterTest
    {
        private ContainerWithMostWater util = new ContainerWithMostWater();

        [TestMethod]
        public void TestSimple()
        {
            Assert.AreEqual(1, this.util.MaxArea(new int[] {1, 1}));
            Assert.AreEqual(10, this.util.MaxArea(new int[] {1, 0, 50, 0, 0, 0, 0, 0, 0, 0, 1}));
        }
    }
}
