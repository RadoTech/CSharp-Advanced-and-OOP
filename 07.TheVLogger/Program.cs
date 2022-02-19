using System;
using System.Collections.Generic;

namespace _07.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> vLogger =
                new Dictionary<string, Dictionary<string, string>>();

            fillVLogger(vLogger);

            Console.WriteLine(String.Join(" ", vLogger));

        }

        static Dictionary<string, Dictionary<string, string>> fillVLogger(Dictionary<string, Dictionary<string, string>> vLogger)
        {
            string[] input = Console.ReadLine().Split(" ");
         
            while (input[0] != "Statistics")
            {
                string vLoggerOne = String.Empty;
                string action = input[1];
                string vLoggerTwo = input[2];
                string stat = String.Empty;
                string theVLogger = String.Empty;

                if (input.Length == 1)
                {
                    stat = input[0];
                }
                else if (input.Length == 2)
                {
                    vLoggerOne = input[0];
                }
                else if (input.Length == 3)
                {
                    theVLogger = input[2] + " " + input[3];
                }

                    if (!vLogger.ContainsKey(vLoggerOne))
                {
                    vLogger.Add(vLoggerOne, new Dictionary<string, string>());
                }
                else if (!vLogger[vLoggerOne].ContainsKey(vLoggerTwo))
                {
                    if (input.Length == 2)
                    {
                        vLogger[vLoggerOne].Add(vLoggerTwo, action);
                    }
                    else if (input.Length == 3)
                    {
                        vLogger[vLoggerOne].Add(theVLogger, action);
                    }
                }
                else
                {
                    vLogger[vLoggerOne][vLoggerTwo] = action;
                }
               
                input = Console.ReadLine().Split(" ");
            }

            return vLogger;
        }
    }
}
