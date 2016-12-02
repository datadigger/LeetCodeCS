namespace LeetCode
{
    public class SpiralMatrixII
    {
        public int[,] GenerateMatrix(int n) {
            if (n == 0)
            {
                return new int[0, 0];
            }

            var result = new int[n, n];

            var used = new int[n, n];

            var total = n * n;

            var directions = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

            var currentDirection = 0;
            var currentX = 0;
            var currentY = 0;

            var current = 0;

            while (current < total)
            {
                if (used[currentX, currentY] == 0)
                {
                    result[currentX, currentY] = ++current;
                    used[currentX, currentY] = 1;
                }

                var nextX = currentX + directions[currentDirection, 0];
                var nextY = currentY + directions[currentDirection, 1];

                if (nextX < 0 || nextX >= n || nextY < 0 || nextY >= n
                    || used[nextX, nextY] == 1)
                {
                    currentDirection = (currentDirection + 1) % 4;
                }
                else
                {
                    currentX = nextX;
                    currentY = nextY;
                }
            }

            return result;
        }
    }
}