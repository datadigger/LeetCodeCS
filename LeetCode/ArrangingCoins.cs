using System;
namespace LeetCode
{
  public class ArrangingCoins
  {
    public int ArrangeCoins(int n)
    {
      if (n <= 1) {
        return n;
      }

      int low = 1;
      int high = n;

      while (low < high) {
        int mid = (low + high) / 2;

        if (mid * (mid + 1) / 2 <= n) {
          low = mid + 1;
        } else {
          high = mid;
        }
      }

      return low - 1;
    }

    public int ArrangeCoins2(int n) {
      return (int)((-1 + Math.Sqrt(1 + 8 * (long)n)) / 2);
    }
  }
}
