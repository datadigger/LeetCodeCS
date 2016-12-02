namespace LeetCode
{
    using NUnit.Framework;

    [TestFixture]
    public class SpiralMatrixIITest
    {
        private readonly SpiralMatrixII util = new SpiralMatrixII();

        [Test]
        public void TestSimple()
        {
            var expect = new int[,] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };

            Assert.AreEqual(expect, this.util.GenerateMatrix(3));

            Assert.AreEqual(new int[0, 0], this.util.GenerateMatrix(0));
        }
    }
}