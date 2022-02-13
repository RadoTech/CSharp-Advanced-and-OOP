using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdv05Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises: Sets and Dictionaries Advanced
            //Problem 5. Count Symbols

            //Create a program that reads some text from the console and counts the occurrences of each character in it.
            //Print the results in alphabetical (lexicographical) order. 

            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            fillDict(symbols, input);
            printResult(symbols);

    }

        private static void printResult(SortedDictionary<char, int> symbols)
        {
            foreach (KeyValuePair<char, int> kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }

        static SortedDictionary<char, int> fillDict(SortedDictionary<char, int> symbols, string input)
        {
            foreach (char symbol in input)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 0);
                }
                symbols[symbol]++;
            }
            return symbols;
        }
    }
}
