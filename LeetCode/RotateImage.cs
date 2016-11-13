// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RotateImage.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the RotateImage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class RotateImage
    {
        public void Rotate(int[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length);

            for (int i = 0; i < n / 2; ++i)
            {
                for (int j = i; j < n - 1 - i; ++j)
                {
                    var tmp = matrix[i, j];

                    matrix[i, j] = matrix[n - 1 - j, i];

                    matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];

                    matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];

                    matrix[j, n - 1 - i] = tmp;
                }
            }
        }
    }
}
