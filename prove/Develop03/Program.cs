using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding;in all thy ways acknolegdge him, and he shall direct thy paths.");
        
        Scripture theWord = new Scripture();
        
        Word wording = new Word();

        Reference referencing = new Reference("1Nephi",3,7);

        Console.WriteLine("press enter to start memorizing or type 'Quit'");
        string response = Console.ReadLine();

        while (response == "")
            {
                wording.Hide();
                Console.WriteLine("continue selecting");
                string userResponse = Console.ReadLine();
                response = theWord.HideRandomWords();
                response = userResponse;
            }
    }
}