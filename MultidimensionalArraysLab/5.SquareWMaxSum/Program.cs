using System;
using System.Linq;

namespace _5.SquareWMaxSum
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
                int[] currentRow = ParseArrayFromConsole(' ', ','); //second+ time/s reading from console //input: 7 1 3 3 2 1// split by space

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col]; //element by element needs to be taken from the array and filled in the matrix
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) -1; row++) //-1 because we need to make a quadrad and not get out of range exception
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++) //-1 same as above до предпоследното за да направим квадрати но да не излизаме
                {
                    int currentSum = matrix[row, col] // взимаме първата стойност от първи ред първа колона "7"
                        + matrix[row, col + 1] // добавяме на същия ред стойността от следващата колона "1"
                        + matrix[row + 1, col] // добавяме на долния ред стойността от същата колона "1"
                        + matrix[row + 1, col + 1]; // добавяме на долния ред стойността от следващата колона "3"

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine($"{maxSum}");

        }
        static int[] ParseArrayFromConsole(params char[] splitSymbols)   //params works in methods only with array and can take more parameters eg. ' ', ',' etc.                        
            => Console.ReadLine()
                .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
    }

