using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ParseArrayFromConsole();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = ParseArrayFromConsole();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col]; //element by element needs to be taken from the array and filled in the matrix
                }
            }

            long sum = 0;

            foreach (var element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            Console.WriteLine(sum);

        }

        static int[] ParseArrayFromConsole() // same as:                                
            => Console.ReadLine()            // { return Console.ReadLine().Split((new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); }
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
}

