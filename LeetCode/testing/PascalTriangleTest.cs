namespace LeetCode
{
    using NUnit.Framework;

    [TestFixture]
    public class PascalTriangleTest
    {
        private readonly PascalTriangle util = new PascalTriangle();

        [Test]
        public void TestSimple()
        {
            var results = this.util.Generate(6);

            Assert.IsTrue(6 == results.Count);

            Assert.AreEqual(new int[] {1}, results[0]);
            Assert.AreEqual(new int[] {1, 1}, results[1]);
            Assert.AreEqual(new int[] {1, 2, 1}, results[2]);
            Assert.AreEqual(new int[] {1, 3, 3, 1}, results[3]);
            Assert.AreEqual(new int[] {1, 4, 6, 4, 1}, results[4]);
            Assert.AreEqual(new int[] {1, 5, 10, 10, 5, 1}, results[5]);
        }
    }
}