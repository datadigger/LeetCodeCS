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
    class RotateImageTest
    {
        private readonly RotateImage util = new RotateImage();

        [Test]
        public void TestSimple()
        {
            var image1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var rotatedImage = new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };

            this.util.Rotate(image1);
            Assert.That(rotatedImage, Is.EqualTo(image1));
        }

        [Test]
        public void TestSimple2()
        {
            var image = new int[,]
                            {
                                    { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 },
                                    { 21, 22, 23, 24, 25 }
                            };

            var rotateImage = new int[,]
                                  {
                                          { 21, 16, 11, 6, 1 }, { 22, 17, 12, 7, 2 }, { 23, 18, 13, 8, 3 },
                                          { 24, 19, 14, 9, 4 }, { 25, 20, 15, 10, 5 }
                                  };

            this.util.Rotate(image);
            Assert.That(rotateImage, Is.EqualTo(image));
        }
    }
}
