using System;

namespace Mark8TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, we are about to start exploring Sweetwater Plantation.");
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
                }
                else
                {
                    Console.WriteLine("Okay, some people don't like to get scared. We understand.");
                }
            }
            else
            {
                Console.WriteLine("It's okay. We understand. We can go without you.");
            }

            
                    
                

            

        }
    }
}
