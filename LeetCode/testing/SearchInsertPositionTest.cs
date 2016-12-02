namespace LeetCode
{
    using NUnit.Framework;

    [TestFixture]
    public class SearchInsertPositionTest
    {
        private readonly SearchInsertPosition util = new SearchInsertPosition();

        [Test]
        public void TestSimple()
        {
            Assert.IsTrue(2 == this.util.SearchInsert(new int[] {1, 3, 5, 6}, 5));
            Assert.IsTrue(1 == this.util.SearchInsert(new int[] {1, 3, 5, 6}, 2));
            Assert.IsTrue(4 == this.util.SearchInsert(new int[] {1, 3, 5, 6}, 7));
            Assert.IsTrue(0 == this.util.SearchInsert(new int[] {1, 3, 5, 6}, 0));
        }
    }
}