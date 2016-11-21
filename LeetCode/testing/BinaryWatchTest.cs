namespace LeetCode
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class BinaryWatchTest
    {

        private readonly BinaryWatch util = new BinaryWatch();

        [Test]
        public void TestSimple()
        {
            var set1 = new HashSet<string> { "1", "2" };

            var set2 = new HashSet<string> { "2", "1" };

            Assert.IsTrue(HashSet<string>.CreateSetComparer().Equals(set1, set2));
        }

    }
}