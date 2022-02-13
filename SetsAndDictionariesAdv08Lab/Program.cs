using System;
using System.Collections.Generic;

namespace SetsAndDictionariesAdv08Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab: Sets and Dictionaries Advanced
            //8. SoftUni Party

            //There is a party in SoftUni. Many guests are invited and there are two types of them: VIP and Regular.
            //When a guest comes, check if he/she exists in any of the two reservation lists.
            //All reservation numbers will be with the length of 8 chars.
            //All VIP numbers start with a digit.
            //First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
            //"PARTY" – After this command, you will begin receiving the reservation numbers of the people, who came to the party.
            //"END" – The party is over and you have to stop the program and print the appropriate output.
            //In the end, print the count of the guests who didn't come to the party, and afterward, print their reservation numbers. the VIP guests must be first.

            bool partyStarted = false;
            HashSet<string> vipPeople = new HashSet<string>();
            HashSet<string> ordinaryPeople = new HashSet<string>();

            string command; //same as string command = String.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partyStarted = true;
                    continue;
                }

                if (partyStarted) //same as if (partyStarted == true)
                {
                    if (isVip(command)) //using the method to check if the name is VIP person
                    {
                        vipPeople.Remove(command); //if Party started - removing those who came in order to get those who didn't.
                    }
                    else
                    {
                        ordinaryPeople.Remove(command);
                    }

                }
                else
                {
                    if (isVip(command)) //using the method to check if the name is VIP person
                    {
                        vipPeople.Add(command); //if Party doesn't started yet - adding reservations
                    }
                    else
                    {
                        ordinaryPeople.Add(command);
                    }
                }
            }

            Console.WriteLine(vipPeople.Count + ordinaryPeople.Count); //printing the count of people who didn't come

            foreach (var person in vipPeople)
            {
                Console.WriteLine(person); //printing the name of each VIP person who didn't come
            }

            foreach (var person in ordinaryPeople)
            {
                Console.WriteLine(person); //printing the name of the rest of persons who didn't come
            }
        }

        private static bool isVip(string number) // declalring a method
        {
            int num = 0; //will not be used but needs to be declared
            return int.TryParse(number.Substring(0, 1), out num); //Substring starts at position 0 and has length 1,
                                                                  //means we check only the first character if it is a digit or not
        }
    }
}
