namespace LeetCode
{
    using System.Linq;

    using NUnit.Framework;

    [TestFixture]
    public class SpiralMatrixTest
    {
        private readonly  SpiralMatrix util = new SpiralMatrix();

        [Test]
        public void TestSimple()
        {
            var expect = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            var input = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            var result = this.util.SpiralOrder(input);
            Assert.AreEqual(expect, result.ToArray());
        }

    }
}