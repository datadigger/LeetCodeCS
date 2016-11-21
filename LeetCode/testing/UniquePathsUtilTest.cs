namespace LeetCode
{
    using NUnit.Framework;

    [TestFixture]
    public class UniquePathsUtilTest
    {
        private readonly UniquePathsUtil util = new UniquePathsUtil();

        [Test]
        public void TestSimple()
        {
            Assert.That(1, Is.EqualTo(expected: this.util.UniquePaths(1, 1)));
            Assert.That(2, Is.EqualTo(expected: this.util.UniquePaths(2, 2)));
            Assert.That(0, Is.EqualTo(expected: this.util.UniquePaths(0, 1)));
            Assert.That(0, Is.EqualTo(expected: this.util.UniquePaths(2, 0)));
        }
    }
}