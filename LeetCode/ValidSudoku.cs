// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidSudoku.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ValidSudoku type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LeetCode
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            for (int i = 0; i < 9; ++i)
            {
                if (!this.CheckRow(board, i))
                {
                    return false;
                }
            }

            for (int i = 0; i < 9; ++i)
            {
                if (!this.CheckCol(board, i))
                {
                    return false;
                }
            }

            foreach (var i in new int[] { 0, 3, 6 })
            {
                foreach (var j in new int[] { 0, 3, 6 })
                {
                    if (!this.CheckSmallSqure(board, i, j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool CheckSmallSqure(char[,] board, int i, int j)
        {
            var toBeChecked = new char[9];
            var index = 0;
            for (int i1 = i; i1 < i + 3; ++i1)
            {
                for (int j1 = j; j1 < j + 3; ++j1)
                {
                    toBeChecked[index++] = board[i1, j1];
                }
            }

            return this.DoCheck(toBeChecked);
        }

        private bool CheckCol(char[,] board, int i)
        {
            var toBeChecked = new char[9];
            for (int j = 0; j < 9; ++j)
            {
                toBeChecked[j] = board[j, i];
            }

            return this.DoCheck(toBeChecked);
        }

        private bool CheckRow(char[,] board, int i)
        {
            var toBeChecked = new char[9];

            for (int j = 0; j < 9; ++j)
            {
                toBeChecked[j] = board[i, j];
            }

            return this.DoCheck(toBeChecked);

        }

        private bool DoCheck(char[] toBeChecked)
        {
            var result = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            for (int i = 0; i < 9; ++i)
            {
                if (toBeChecked[i] != '.')
                {
                    --result[toBeChecked[i] - '0'];
                }
            }

            foreach (var i in result)
            {
                if (i < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
