using System;

namespace Mark8TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to The Best Park Ever!");
            Console.WriteLine("Are you ready to start exploring the park?");

            string response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Great!Lets go.");
                Console.WriteLine("Would you like to ride the roller coaster?");
                response = Console.ReadLine();

                if (response == "yes")
                {
                    Console.WriteLine("Okay, we will ride The Fog");
                }
                else
                {
                    Console.WriteLine("Okay, would you like to find another ride?");
                }
                if (response == "yes")
                {
                    Console.WriteLine("Great, we will walk around until we find something you want to ride.");
                }
                else
                {
                    Console.WriteLine("Okay, would you like to go get some food?");
                }
                if (response == "yes")
                {
                    Console.WriteLine("Okay, there is a food stand right over here.");
                }
                else
                {
                    Console.WriteLine("Okay, we can find something you will like instead.");
                }
                    
                

            }

        }
    }
}
