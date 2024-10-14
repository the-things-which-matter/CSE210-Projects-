using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding;in all thy ways acknolegdge him, and he shall direct thy paths.");
        
        Reference newReference = new Reference("Proverbs",3,5,6);

        Scripture theWord = new Scripture(newReference,"Trust in the Lord with all thine heart and lean not unto thine own understanding;in all thy ways acknolegdge him, and he shall direct thy paths.");
        
        Categories reminder = new Categories();
        reminder._bible ="Bible";
        reminder._bookOfMormon = "Book Of Mormon";
        reminder._PearlOfGreatPrice= "Pearl Of Greate Price";
        reminder._DoctrineAndCovenants= "Doctrine And Covenants";


        string response = "";

        while (response.ToLower() != "quit" && !theWord.IsCompletelyHidden())
        {
            Console.Clear(); // Clear the console screen
            // Display the current state of the scripture
            Console.WriteLine(theWord.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type 'Quit' to exit.");
            response = Console.ReadLine(); // Get user input

            Console.WriteLine("The are other scxripture types from which you can get your next verse to memorize");
            reminder.ImportantScriptureReminder();


            // If the user presses Enter, hide one random word
            if (string.IsNullOrEmpty(response))
            {
                theWord.HideRandomWords(1); // Hide one random word
            }
        }
    }
}
