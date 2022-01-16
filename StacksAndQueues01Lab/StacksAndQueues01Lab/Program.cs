using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues01Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Reverse Strings
            //Create a program that: Reads an input string; Reverses it using a Stack<T>;
            //Prints the result back at the terminal

            var myStack = new Stack<char>(Console.ReadLine());

            while (myStack.Any())
            {
                Console.Write(myStack.Pop());
            }
        }
    }
}
