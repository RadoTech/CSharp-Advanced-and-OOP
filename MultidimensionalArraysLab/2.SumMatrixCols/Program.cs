using System;
using System.Linq;

namespace _2.SumMatrixCols
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ParseArrayFromConsole(' ', ','); //first time reading from console //input: 3, 6 //split by space and coma

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = ParseArrayFromConsole(' '); //second+ time/s reading from console //input: 7 1 3 3 2 1// split by space

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col]; //element by element needs to be taken from the array and filled in the matrix
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfCurrentCollum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCurrentCollum += matrix[row, col];
                }

                Console.WriteLine(sumOfCurrentCollum);
            }
        }
        static int[] ParseArrayFromConsole(params char[] splitSymbols)   //params works in methods only with array and can take more parameters eg. ' ', ',' etc.                        
            => Console.ReadLine()
                .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
}

