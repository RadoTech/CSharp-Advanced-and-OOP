using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdv04Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises: Sets and Dictionaries Advanced
            //Problem 4.	Even Times

            //Create a program that prints a number from a collection, which appears an even number of times in it. On the first line, 
            //you will be given n – the count of integers you will receive. On the next n lines, you will be receiving the numbers. 
            //It is guaranteed that only one of them appears an even number of times. Your task is to find that number and print it in the end. 

            var inputCount = int.Parse(Console.ReadLine());
            var inputDictA = new Dictionary<int, int>();
            var nextNum = Console.ReadLine();
            var inputList= new List<int>();

            for (int i = 0; i < inputCount; i++)
            {
                inputList.Add(int.Parse(nextNum));

                if (i == inputCount -1)
                {
                    break;
                }
                nextNum = Console.ReadLine();
            }

            foreach (var item in inputList)
            {
                if (inputDictA.ContainsKey(item)) 
                {
                    inputDictA[item]++; //if there is such key(number) already in the collection increase the value (the appearance) with 1
                }
                else
                {
                    inputDictA.Add(item, 1); //if its a new key then add the value(appearance) for the first time
                }
            }

            foreach (var item in inputDictA)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
            
        }
    }
}
