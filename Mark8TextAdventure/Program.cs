using System;

namespace Mark8TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, we are about to start exploring the haunted Sweetwater Plantation.");
            Console.WriteLine("Would you like to come with us?");

            string response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Great! Lets go.");
                Console.WriteLine("As we are walking up to the house, the fog is starting to roll in over the family cemetery.");
                Console.WriteLine("Would you like to continue to the house?");
                response = Console.ReadLine();

                if (response == "yes")
                {
                    Console.WriteLine("Okay, lets go!");
                    Console.WriteLine("As we enter the house, we enter into a big room with old furniture.");
                    Console.WriteLine("There is a piano in the back of the room! The ledgend says if you play the piano, the lady of the house will come out to play with you.");
                    Console.WriteLine("Would you like to play the piano?");
                    response = Console.ReadLine();

                    if (response == "yes")
                    {
                        Console.WriteLine("Awesome! I can't wait to see what happens!");
                    }
                    else
                    {
                        Console.WriteLine("We understand, not everyone likes to get scared.");
                    }
                }
                else
                {
                    Console.WriteLine("Okay, some people don't like to get scared. We understand.");
                }
            }
            else
            {
                Console.WriteLine("It's okay. We understand. We will tell you about it when we get back.");
            }

        }
        }
    }
