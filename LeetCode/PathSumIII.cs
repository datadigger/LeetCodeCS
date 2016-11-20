using System;

namespace LeetCode
{
  public class PathSumIII
  {
    public int PathSum(TreeNode root, int sum)
    {
      return DoPathSum(root, sum, true);
    }

    private int DoPathSum(TreeNode root, int sum, bool isOriginalSum) {
      if (root == null) {
        return 0;
      }

      int totalPath = 0;

      if (root.val == sum) {
        ++totalPath;
      }

      if (isOriginalSum) {
        totalPath += PathSum(root.left, sum) + PathSum(root.right, sum);
      } 

      totalPath += DoPathSum(root.left, sum - root.val, false) 
                 + DoPathSum(root.right, sum - root.val, false);

      return totalPath;
    }
  }
}
