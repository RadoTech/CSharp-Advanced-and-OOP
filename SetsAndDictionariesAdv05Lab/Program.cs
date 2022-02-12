using System;
using System.Collections.Generic;

namespace SetsAndDictionariesAdv05Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab: Sets and Dictionaries Advanced
            //5. Cities by Continent and Country

            //Creat:e a program that reads continents, countries, and their cities put them in a nested dictionary and prints them.
            //Input:
            //4
            //Europe Bulgaria Sofia
            //Asia China Beijing
            //Asia China Shanghai
            //Asia Japan Tokyo
            //Output:
            //Europe:
            //    Bulgaria->Sofia, Plovdiv
            //Asia:
            //    China->Beijing, Shanghai
            //    Japan->Tokyo

            int inputLen = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < inputLen; i++)
            {
                string[] inputArray = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = inputArray[0];
                string country = inputArray[1];
                string city = inputArray[2];

                if (continents.ContainsKey(continent) == false) // == (!continents.ContainsKey(continent)// checking do we have to continent ?
                {
                    continents.Add(continent, new Dictionary<string, List<string>>()); //adding current continent AND creating the nested Dictionary
                }

                if (continents[continent].ContainsKey(country) == false) //nested -> now checking do we have the country ?
                {
                    continents[continent].Add(country, new List<string>()); //adding current country AND creating the List in the nested Dictionary
                }
                //NO NEED to check do we have the city becasue it is List and not Dictionary.Key, hence no need to be unique

                continents[continent][country].Add(city); //adding current city
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:"); // continet.Key == continent == inputArray[0];

                foreach (var country in continent.Value) //continet.Value == country == inputArray[1];
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}"); //country.Value == city == inputArray[0];
                }
            }
        }
    }
}
