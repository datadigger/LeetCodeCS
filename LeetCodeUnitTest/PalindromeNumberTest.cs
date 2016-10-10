using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    using LeetCode;

    [TestClass]
    class PalindromeNumberTest
    {
        private PalindromeNumber util = new PalindromeNumber();

        [TestMethod]
        public void testSimple()
        {
           Assert.IsTrue(this.util.IsPalindrome(121)); 
           Assert.IsTrue(this.util.IsPalindrome(1221)); 
           Assert.IsTrue(this.util.IsPalindrome(111)); 
           Assert.IsTrue(this.util.IsPalindrome(1111)); 
       
           Assert.IsTrue(this.util.IsPalindrome(1212)); 
           Assert.IsFalse(this.util.IsPalindrome(123)); 

           
           Assert.IsFalse(this.util.IsPalindrome(321)); 
           Assert.IsFalse(this.util.IsPalindrome(10)); 
        }

    }
}
