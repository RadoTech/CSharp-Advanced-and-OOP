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

            var myStack = new Stack<char>(Console.ReadLine());

            while (myStack.Any())
            {
                Console.Write(myStack.Pop());
            }
        }
    }
}
