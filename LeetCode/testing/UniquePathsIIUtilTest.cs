namespace LeetCode
{
    using NUnit.Framework;

    [TestFixture]
    public class UniquePathsIIUtilTest
    {
        private readonly UniquePathsIIUtil util = new UniquePathsIIUtil();

        [Test]
        public void TestSimple()
        {
            var obstacleGrid = new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 }, };

            Assert.That(2, Is.EqualTo(this.util.UniquePathsWithObstacles(obstacleGrid)));
        }

        [Test]
        public void TestSimple2()
        {
            var obstacleGrid = new int[,] { { 0, 1}, {1, 0}};

            Assert.That(0, Is.EqualTo(this.util.UniquePathsWithObstacles(obstacleGrid)));
        }

        [Test]
        public void TestSimple3()
        {
            var obstacleGrid = new int[,] { { 1, 0} };

            Assert.That(0, Is.EqualTo(this.util.UniquePathsWithObstacles(obstacleGrid)));
        }
    }
}