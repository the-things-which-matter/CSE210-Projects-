using System;
using System.Net;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");


        Console.WriteLine("Welcome to the Breathing Activity.");
        BreathingActivity breathing = new BreathingActivity();

        ListingActivity listing = new ListingActivity();

        ReflectingActivity reflect = new ReflectingActivity();

       // Activity active = new Activity();

       /// Console.WriteLine("Welcome to the Activity Program!");
       // Console.WriteLine("Select an activity:");
       // Console.WriteLine("1. Breathing Activity");
       // Console.WriteLine("2. Listing Activity");
        //Console.WriteLine("3. Reflecting Activity");

         Console.WriteLine("Welcome to the Activity Program!");

        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Activity activity;

                if (choice == 1)
                {
                    activity = new BreathingActivity();
                }
                else if (choice == 2)
                {
                    activity = new ListingActivity();
                }
                else if (choice == 3)
                {
                    activity = new ReflectingActivity();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue; 
                }

                activity.Run();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

      
        

    
}