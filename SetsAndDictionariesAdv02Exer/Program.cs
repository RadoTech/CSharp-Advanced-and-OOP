using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdv02Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises: Sets and Dictionaries Advanced
            //Problem 2.	Sets of Elements

            //Create a program that prints a set of elements. 
            //On the first line, you will receive two numbers - n and m, which represent the lengths of two separate sets. 
            //On the next n + m lines, you will receive n numbers, which are the numbers in the first set, and m numbers, which are in the second set.
            //Find all the unique elements that appear in both of them and print them in the order in which they appear in the first set - n.
            //For example:
            //Set with length n = 4: { 1, 3, 5, 7}
            //Set with length m = 3: { 3, 4, 5}
            //Set that contains all the elements that repeat in both sets -> { 3, 5}

            var inputLens = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var firstLen = inputLens[0];
            var secondLen = inputLens[1];

            var firstSet = new List<int>(firstLen);
            var secondSet = new List<int>(secondLen);
            var inputSetNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstLen + secondLen; i++)
            {
                if (i <= firstLen)
                {
                    firstSet.Add(inputSetNumber);
                }
                else
                {
                    secondSet.Add(inputSetNumber);
                }

                if (i == firstLen + secondLen)
                {
                    break;
                }

                inputSetNumber = int.Parse(Console.ReadLine());
            }

            var hashSet = new HashSet<int>();

            for (int i = 0; i < firstLen; i++)
            {
                for (int y = 0; y < secondLen; y++)
                {
                    if (firstSet[i] == secondSet[y])
                    {
                        hashSet.Add(firstSet[i]);
                        //Console.WriteLine($"firstSet: {firstSet[i]}, secondSet: {secondSet[y]}");
                    }
                }
            }
            Console.WriteLine(string.Join(" ", hashSet));
        }
    }
}
