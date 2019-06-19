using System;

namespace Mark8TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to Blahblah Park!");
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
                    Console.WriteLine("Now that the ride is moving, would you like to stand up");

                    if (response == "yes")
                    {
                        Console.WriteLine("Oh, no! Your head fell off!");
                        Console.WriteLine("Sad day!");
                    }
                    else
                    {
                        Console.WriteLine("Weeeee!");
                    }
                }
                else
                {
                    Console.WriteLine("Ok, would you like to find another ride?");

                    if (response == "yes")
                    {
                        Console.WriteLine("Great, we will walk around until we find something you want to ride.");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
