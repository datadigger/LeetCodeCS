namespace LeetCode
{
    using System.Collections.Generic;
    using System.Runtime;

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

        [Test]
        public void TestSimple2()
        {
            Assert.AreEqual("0:00", this.util.ReadBinaryWatch(0)[0]);
        }


        [Test]
        public void TestSimple3()
        {
            var expectedSet1 = new HashSet<string>
                                   {
                                       "1:00",
                                       "2:00",
                                       "4:00",
                                       "8:00",
                                       "0:01",
                                       "0:02",
                                       "0:04",
                                       "0:08",
                                       "0:16",
                                       "0:32"
                                   };

            var actualSet = new HashSet<string>(this.util.ReadBinaryWatch(1));

            Assert.IsTrue(HashSet<string>.CreateSetComparer().Equals(expectedSet1, actualSet));
        }

    }
}