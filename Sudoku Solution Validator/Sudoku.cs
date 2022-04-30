using System;
using System.Linq;


namespace Sudoku_Solution_Validator
{
    internal class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            int[] arrayToCheck = new int[9];
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    arrayToCheck[j] = board[i][j];
                }
                if (!CheckNumber(arrayToCheck)) return false;
            }
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    arrayToCheck[j] = board[j][i];
                }
                if (!CheckNumber(arrayToCheck)) return false;
            }
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    arrayToCheck[j] = board[j / 3 + i % 3 * 3][j % 3 + i / 3 * 3];
                }
                if (!CheckNumber(arrayToCheck)) return false;
            }
            return true;
        }
        private static bool CheckNumber(int[] checkArray)
        {
            int[] allNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return allNumbers.All(checkArray.Contains);
        }
    }
}
