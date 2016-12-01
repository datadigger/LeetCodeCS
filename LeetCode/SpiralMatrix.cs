namespace LeetCode
{
    using System;
    using System.Collections.Generic;

    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var results = new List<int>();

            if (matrix.Length == 0)
            {
                return results;
            }

            var w = matrix.GetUpperBound(0) + 1;
            var h = matrix.GetUpperBound(1) + 1;

            var used = new int[w, h];

            var directions = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

            var currentDirection = 0;
            var currentX = 0;
            var currentY = 0;

            var total = 0;

            while (total < matrix.Length)
            {
                if (used[currentX, currentY] == 0)
                {
                    results.Add(matrix[currentX, currentY]);

                    used[currentX, currentY] = 1;

                    ++total;
                }

                var nextX = currentX + directions[currentDirection, 0];
                var nextY = currentY + directions[currentDirection, 1];

                if (nextX < 0 || nextX >= w || nextY < 0 || nextY >= h
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

            return results;
        }
    }
}