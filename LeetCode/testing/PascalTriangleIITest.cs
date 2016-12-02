namespace LeetCode
{
    using System.Linq;

    using NUnit.Framework;

    [TestFixture]
    public class PascalTriangleIITest
    {
        private readonly PascalTriangleII util = new PascalTriangleII();

        [Test]
        public void TestSimple()
        {
            Assert.AreEqual(new int[] {1}, this.util.GetRow(0).ToArray());
            Assert.AreEqual(new int[] {1, 1}, this.util.GetRow(1).ToArray());
            Assert.AreEqual(new int[] {1, 2, 1}, this.util.GetRow(2).ToArray());
            Assert.AreEqual(new int[] {1, 3, 3, 1}, this.util.GetRow(3).ToArray());
        }
    }
}