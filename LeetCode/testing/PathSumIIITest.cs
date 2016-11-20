using System;
using NUnit.Framework;

namespace LeetCode
{
  [TestFixture]
  public class PathSumIIITest
  {
    private readonly PathSumIII util = new PathSumIII();
    
    [Test]
    public void TestSimple() {
      TreeNode node1 = new TreeNode(10);
      TreeNode node2 = new TreeNode(5);
      TreeNode node3 = new TreeNode(-3);
      TreeNode node4 = new TreeNode(3);
      TreeNode node5 = new TreeNode(2);
      TreeNode node6 = new TreeNode(11);
      TreeNode node7 = new TreeNode(3);
      TreeNode node8 = new TreeNode(-2);
      TreeNode node9 = new TreeNode(1);

      node1.left = node2;
      node1.right = node3;

      node2.left = node4;
      node2.right = node5;

      node3.right = node6;

      node4.left = node7;
      node4.right = node8;

      node5.right = node9;

      Assert.That(3, Is.EqualTo(util.PathSum(node1, 8)));
    }

    [Test]
    public void TestSimple2() {
      TreeNode node1 = new TreeNode(2);
      TreeNode node2 = new TreeNode(2);
      node1.left = node2;

      Assert.That(0, Is.EqualTo( util.PathSum(node1, 3)));
      Assert.That(2, Is.EqualTo(util.PathSum(node1, 2)));
    }
  }
}
