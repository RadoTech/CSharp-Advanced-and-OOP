using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdv03Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises: Sets and Dictionaries Advanced
            //Problem 3.	Periodic Table

            //Create a program that keeps all the unique chemical elements.
            //On the first line, you will be given a number n - the count of input lines that you are going to receive.
            //On the next n lines, you will be receiving chemical compounds, separated by a single space. 
            //Your task is to print all the unique ones in ascending order:

            var inputLen = int.Parse(Console.ReadLine());
            string inputElement = Console.ReadLine();
            var elementsList = new List<string>();

            var elementsSet = new SortedSet<string>();

            for (int i = 1; i <= inputLen; i++)
            {
                elementsList = inputElement.Split(" ").ToList();

                for (int inside = 0; inside < elementsList.Count; inside++) //inside == each element on a single input row
                {
                    elementsSet.Add(elementsList[inside]);
                }

                if (i == inputLen)
                {
                    break;
                }

                elementsList.RemoveAt(0);
                inputElement = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", elementsSet));
        }
    }
}
