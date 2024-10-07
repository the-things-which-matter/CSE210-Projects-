using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        string userFile ="";
        string numberReply = "";

        //Console.WriteLine("Hello Develop02 World!");
        PromptGenerator generate = new PromptGenerator();
        
        generate._displayOptions.Add("what was your favorite part of the day");
        generate._displayOptions.Add("what made you smile?");
        generate._displayOptions.Add("what made you frastrated today?");
        generate._displayOptions.Add("How did you see the lord's hand in your life today");


        Entry newEntry = new Entry();
        newEntry.Display();
        newEntry._promptText = generate.DisplayQuestions(userChoice);
        
        Entry userEntrty = new Entry();
        userEntrty._date ="2/10/224";
        userEntrty.Display();

        Journal inJournal = new Journal();

        Console.WriteLine(generate.GetRandomPrompt());

        //string userReturn = Console.ReadLine();
        
       // string userReply = Console.ReadLine();
       // int numberReply = int.Parse(userReply);
        while (numberReply != "5")
            {
                Console.WriteLine("1.Write");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Load");
                Console.WriteLine("4.Save");
                Console.WriteLine("5.Quit");

                numberReply = Console.ReadLine();
                if (numberReply == "1")
                    while(numberReply == "1")
                       {
                            Console.WriteLine(generate.DisplayQuestions( userChoice));
                        }

                else if (numberReply == "2")
                    {
                        Console.WriteLine( newEntry.Display());
                    }
                else if (numberReply == "3")
                    {
                        Console.WriteLine("Enter a File Name");
                        string userInput = Console.ReadLine();
                        inJournal.LoadFromFile(userInput);
                    }
                else if (numberReply == "4")
                    {
                        Console.WriteLine("whaT is the file name?");
                        string userFileName = Console.ReadLine();
                        inJournal.SaveToFile(userFileName);

                    }
                else
                    {
                        Console.WriteLine("Thanks for using the program");
                    }
            }
            
        


        
    }
}