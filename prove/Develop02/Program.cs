using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        string userFile ="";
        //int userReply = 0;

        //Console.WriteLine("Hello Develop02 World!");
        //int userReturn = -2;
        //Random randomNumberGenerate = new Random();
        //string realNumber = randomNumberGenerate.Next("what frastrated you today","what made you smile","what made you think about life");
      

        PromptGenerator generate = new PromptGenerator();
        //while(userReturn != 5)

        generate._displayOptions.Add("what was your favorite part of the day");
        generate._displayOptions.Add("what made you smile?");
        generate._displayOptions.Add("what made you frastrated today?");
        generate._displayOptions.Add("How did you see the lord's hand in your life today");



       // generate._prompts.Add("1.Write");
        //generate._prompts.Add("2.Display");
        //generate._prompts.Add("3.Load");
        //generate._prompts.Add("4.Save");
        //generate._prompts.Add("5.Quit");

        Entry newEntry = new Entry();
        newEntry.Display();
        newEntry._promptText = generate.DisplayQuestions(userChoice);
        
       // generate.GetRandomPrompt();
       // generate._NameGenerator();

        //if (userReturn == "1")
           // {
               // generate._NameGenerator();
          //  }
       // else
         //..   {
          //      Console.WriteLine("try again");
           // }
       // Console.WriteLine(userReturn);


        Entry userEntrty = new Entry();
        userEntrty._date ="2/10/224";
        userEntrty.Display();

        Journal inJournal = new Journal();
 


        


        Console.WriteLine(generate.GetRandomPrompt());

        Console.WriteLine("Please Select onr of the following choices;");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");

         

        //string userReturn = Console.ReadLine();
        
        string userReply = Console.ReadLine();
        int numberReply = int.Parse(userReply);
        while (numberReply != 5)
            {
                if (numberReply == 1)
                    while(numberReply ==1)
                       {
                            Console.WriteLine(generate.DisplayQuestions( userChoice));
                        }

                else if (numberReply == 2)
                    {
                        Console.WriteLine( newEntry.Display());
                    }
                else if (numberReply == 3)
                    {
                            Console.WriteLine(inJournal.LoadFile(userFile));
                    }
                else if (numberReply ==4)
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