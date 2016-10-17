using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    using LeetCode;

    /// <summary>
    /// Summary description for LetterCombinationsOfPhoneNumberTest
    /// </summary>
    [TestClass]
    public class LetterCombinationsOfPhoneNumberTest
    {
        private LetterCombinationsOfPhoneNumber util = new LetterCombinationsOfPhoneNumber();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(9, this.util.LetterCombinations("23").Count);
        }
    }
}
