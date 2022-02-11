using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdv04Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            //input:
            //lidl, juice, 2.30

            string command = Console.ReadLine();

            while (command?.ToUpper() != "REVISION")
            {
                string[] tokens = command
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (shops.ContainsKey(tokens[0]) == false) // == !shop.ContainsKey(tokens[0])
                {
                    shops[tokens[0]] = new Dictionary<string, double>(); //adding the key and creating the nested Dictionary in case missing
                }

                shops[tokens[0]].Add(tokens[1], double.Parse(tokens[2])); //entering the values in the nested Dict after we already have the key

                command = Console.ReadLine();
            }
            //output:
            //fantastico ->
            //Product: apple, Price: 1.2
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }


        }
    }
}
