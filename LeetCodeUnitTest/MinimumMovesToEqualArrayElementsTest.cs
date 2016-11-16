using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTest
{
    using LeetCode;

    using NUnit.Framework;

    [TestFixture]
    class MinimumMovesToEqualArrayElementsTest
    {
        private readonly MinimumMovesToEqualArrayElements util = new MinimumMovesToEqualArrayElements();

        [Test]
        public void TestSimple()
        {
            Assert.That(3, Is.EqualTo(this.util.MinMoves(new int[] {1, 2, 3})));
            Assert.That(7, Is.EqualTo(this.util.MinMoves(new int[] {2, 9})));
            Assert.That(0, Is.EqualTo(this.util.MinMoves(new int[] {2 })));

        }
    }
}
