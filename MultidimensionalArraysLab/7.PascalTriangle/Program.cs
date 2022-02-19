using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] pascalTriangle = new int[rows][];

            if (rows >= 1)
            {
                pascalTriangle[0] = new int[] { 1 };
            }
            if (rows >= 2)
            {
                pascalTriangle[0] = new int[] { 1, 1 };
            }

            for (int row = 2; row < rows; row++)
            {
                pascalTriangle[row] = new int[row + 1];
                pascalTriangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] =
                        pascalTriangle[row - 1][col] +
                        pascalTriangle[row - 1][col - 1];

                }

                pascalTriangle[row][row] = 1;
            }

            foreach (var currentRow in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", currentRow));
            }
        }
    }
}
