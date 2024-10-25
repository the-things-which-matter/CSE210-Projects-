using System;
using System.Net;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");


        Console.WriteLine("Welcome to the Breathing Activity.");
        BreathingActivity breathing = new BreathingActivity();

        ListingActivity listing = new ListingActivity();

        ReflectingActivity reflect = new ReflectingActivity();

        Activity active = new Activity();

        List<string> animation = new List<string>();
        animation.Add("l");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("l");
        animation.Add("/");

        string answer = "";

        Thread.Sleep(3000);
        do{

        Console.WriteLine("How long would you like for your session?");
        string answer = Console.ReadLine();
        while (answer =="yes")
            
           Console.WriteLine($"Get Ready...{anim}");
            reflect.GetRandomPrompt();
           foreach (string anim in animation)

            reflect.GetRandomQuestion();
            for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(5);
                    Thread.Sleep(1000);
                }
            


           
        } while (answer =="yes");
        Console.WriteLine("Done");


          
        

    }
}