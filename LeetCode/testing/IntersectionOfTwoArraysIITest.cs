namespace LeetCode
{
    using NUnit.Framework;

    [TestFixture]
    public class IntersectionOfTwoArraysIITest
    {
        private readonly IntersectionOfTwoArraysII util = new IntersectionOfTwoArraysII();

        [Test]
        public void TestSimple()
        {
            Assert.AreEqual(new int[] {2, 2}, this.util.Intersect(new int[] {1, 2, 2, 1}, new int[] {2, 2}));
        }
    }
}