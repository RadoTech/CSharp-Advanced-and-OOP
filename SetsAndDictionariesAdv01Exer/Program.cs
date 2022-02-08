using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdv01Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises: Sets and Dictionaries Advanced
            //Problem 1.	Unique Usernames

            //Create a program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones.
            //On the first line, you will be given an integer N. On the next N lines, you will receive one username per line.
            //Print the collection on the console in order of insertion:

            var inputCount = int.Parse(Console.ReadLine());
            var inputName = Console.ReadLine();
            var setNames = new HashSet<string>();

            for (int i = 1; i <= inputCount; i++)
            {
                setNames.Add(inputName);
                inputName = Console.ReadLine();
            }

            foreach (var name in setNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
