using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLen = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            fillDictionary(wardrobe, inputLen);
            string[] clothesToFind = Console.ReadLine().Split(" ");
            string colorToFind = clothesToFind[0];
            string clothToFind = clothesToFind[1];
            printResult(wardrobe, colorToFind, clothToFind);
        }

        static void printResult(Dictionary<string, Dictionary<string, int>> wardrobe, string colorToFind, string clothToFind)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var clothing in kvp.Value)
                {
                    if (colorToFind == kvp.Key && clothToFind == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)"); 
                        continue;
                    }
                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                }
            }
         }

        static Dictionary<string, Dictionary<string, int>> fillDictionary(Dictionary<string, Dictionary<string, int>> wardrobe, int inputLen)
        {
            for (int i = 0; i < inputLen; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string currentColor = input[0]; //Blue
                string[] clothes = input[1].Split(","); //dress,jeans,hat

                if (!wardrobe.ContainsKey(currentColor))
                {
                    wardrobe.Add(currentColor, new Dictionary<string, int>());
                }

                for (int cloth = 0; cloth < clothes.Length; cloth++)
                {
                    if (!wardrobe[currentColor].ContainsKey(clothes[cloth]))
                    {
                        wardrobe[currentColor].Add(clothes[cloth], 0);
                    }

                    wardrobe[currentColor][clothes[cloth]]++;
                }
            }

            return wardrobe;
        }
    }
}
