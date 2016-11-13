using System;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTest
{
    [TestClass]
    public class MergeTwoSortedListTest
    {
        private readonly MergeTwoSortedLists util = new MergeTwoSortedLists();
        [TestMethod]
        public void TestSimple()
        {
            Assert.IsTrue(ListNode.Equals(ListNode.Create(new int[]{1, 2, 3, 4, 5}), 
                util.MergeTwoLists(ListNode.Create(new int[] {1,2,3}), ListNode.Create(new int[] {4, 5}))));

            Assert.IsTrue(ListNode.Equals(ListNode.Create(new int[] {1}), util.MergeTwoLists(null, ListNode.Create(new int[] {1}))));
        }
    }
}
