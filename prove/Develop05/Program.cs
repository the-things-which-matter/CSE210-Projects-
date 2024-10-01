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
       // string response = Console.ReadLine();

        //string response =
        //int number = 7;
      
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
        Console.WriteLine("enetr guess");
        string newGuess =Console.ReadLine();
        int realNumber = int.Parse(newGuess);
        if (realNumber != number)
            {
                Console.WriteLine("try again");
            } 
    }
}