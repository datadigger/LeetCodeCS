using System;

namespace LeetCode
{
  public class PathSumIII
  {
    public int PathSum(TreeNode root, int sum)
    {
      if (root == null) {
        return 0;
      }

      int totalPath = 0;

      if (root.val == sum) {
        ++totalPath;
      }

      totalPath += PathSum(root.left, sum) + PathSum(root.right, sum);
      totalPath += PathSum(root.left, sum - root.val) 
                 + PathSum(root.right, sum - root.val);

      return totalPath;
    }
  }
}
