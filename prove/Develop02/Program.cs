using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        //int userReturn = -2;
        //Random randomNumberGenerate = new Random();
        //string realNumber = randomNumberGenerate.Next("what frastrated you today","what made you smile","what made you think about life");
        Console.WriteLine("Please Select onr of the following choices;");
        string userReturn = Console.ReadLine();

        PromptGenerator generate = new PromptGenerator();
        //while(userReturn != 5)
        generate._prompts.Add("1.Write");
        generate._prompts.Add("2.Display");
        generate._prompts.Add("3.Load");
        generate._prompts.Add("4.Save");
        generate._prompts.Add("5.Quit");
        generate.GetRandomPrompt();
        generate.NameGenerator()

        if (userReturn == "1")
            {
                generate.NameGenerator();
            }
        else
            {
                Console.WriteLine("try again");
            }
        Console.WriteLine(userReturn);
        


        
    }
}