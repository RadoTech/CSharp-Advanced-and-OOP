using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues02Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Stack Sum
            //Create a program that:
            //•	Reads an input of integer numbers and adds them to a stack
            //•	Reads command until "end" is received
            //•	Prints the sum of the remaining elements of the stack

            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            var inputCommand = Console.ReadLine().Split().ToArray();
            var myStack = new Stack<int>(inputArray);

            while (true)
            {
                if (inputCommand[0].ToLower() == "add")
                {
                    for (int i = 1; i < inputCommand.Length; i++)
                    {
                        myStack.Push(int.Parse(inputCommand[i]));
                    }
                }
                else if (inputCommand[0].ToLower() == "remove")
                {
                    if (int.Parse(inputCommand[1]) <= myStack.Count)
                    {
                        int timesToPop = int.Parse(inputCommand[1]);
                        for (int i = 1; i <= timesToPop; i++)
                        {
                            myStack.Pop();
                        }
                    }
                    else
                    {
                        inputCommand = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                    
                }
                else if (inputCommand[0].ToLower() == "end")
                {
                    break;
                }
                inputCommand = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"Sum: {String.Join(" ", myStack.Sum())}");
        }
    }
}
