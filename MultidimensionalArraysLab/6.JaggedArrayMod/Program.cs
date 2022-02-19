using System;
using System.Linq;

namespace _6.JaggedArrayMod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4
             1 2 3 4 5
             6 7 8
             9 10 11 12
             13 14
             Add 0 3 10
             Substract 1 1 10
             Add 3 2 20
             End
             */

            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = currentRow; //copy the whole array row to the current jaggedArray row, as it acts as a normal array(one-dimensional).
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    foreach (int[] currentRow in jaggedArray)
                    {
                        Console.WriteLine(string.Join(" ", currentRow)); //we can use foreach because we don't need index for the print, otherwise we would need for loop
                    }

                    break;
                }

                string[] commandParts = command.Split(" "); //eg. Add 0 3 10
                int row = int.Parse(commandParts[1]);       //eg.  0 
                int col = int.Parse(commandParts[2]);       //eg.  3
                int value = int.Parse(commandParts[3]);     //eg.  10

                if (row < 0 
                    || row >= rows
                    || col < 0
                    || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }

                if (commandParts[0] == "add")               //eg.  Add
                {
                    jaggedArray[row][col] += value;
                }
                else if (commandParts[0] == "substract")
                {
                    jaggedArray[row][col] -= value;
                }
            }

        }
    }
}
