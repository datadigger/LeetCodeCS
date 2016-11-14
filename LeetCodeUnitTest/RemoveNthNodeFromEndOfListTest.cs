namespace LeetCodeUnitTest
{
    using LeetCode;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    [TestClass]
    public class RemoveNthNodeFromEndOfListTest
    {
        private readonly RemoveNthNodeFromEndOfList util = new RemoveNthNodeFromEndOfList();

        [TestMethod]
        public void TestSimple()
        {
            Assert.IsTrue(
                ListNode.Equals(
                    ListNode.Create(new int[] { 2 }),
                    this.util.RemoveNthFromEnd(ListNode.Create(new int[] { 1, 2 }), 2)));

            Assert.IsTrue(
                ListNode.Equals(
                    ListNode.Create(new int[] {1, 2, 4, 5}),
                    this.util.RemoveNthFromEnd(ListNode.Create(new int[] { 1, 2, 3, 4, 5 }), 3)));
        }
    }
}