using System;
using System.Linq;

namespace Sudoku_Solution_Validator
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[][] board = new int[][]
        {
          new int[] {8, 2, 6, 3, 4, 7, 5, 9, 1},
          new int[] {7, 3, 5, 8, 1, 9, 6, 4, 2},
          new int[] {1, 9, 4, 2, 6, 5, 8, 7, 3},
          new int[] {3, 1, 7, 5, 8, 4, 2, 6, 9},
          new int[] {6, 5, 9, 1, 7, 2, 4, 3, 8},
          new int[] {4, 8, 2, 9, 3, 6, 7, 1, 5},
          new int[] {9, 4, 8, 7, 5, 1, 3, 2, 6},
          new int[] {5, 6, 1, 4, 2, 3, 9, 8, 7},
          new int[] {2, 7, 3, 6, 9, 8, 1, 5, 4},
        };
            

            Console.WriteLine(Sudoku.ValidateSolution(board));

        }

    }

}
