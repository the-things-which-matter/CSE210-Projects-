using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //int choice = 0;
        int guess = 0;
        while(guess!= 5)
    {
        Console.WriteLine("select one of these");
        Console.WriteLine("1.sleep");
        Console.WriteLine("2.Eat");
        Console.WriteLine("3.Drink");
        Console.WriteLine("what would you like to do");
        string feed = Console.ReadLine();
        int newFeed = int.Parse(feed);

        if (feed == "1")
            {
                Console.WriteLine("1");
            }
        else if (feed == "2")
            {
                Console.WriteLine("2");
            }
        else if (feed == "3")
            {
                Console.WriteLine("3");
            }
        else
            {
                Console.WriteLine("4");
            }
        guess = newFeed;
      

    }
     Console.WriteLine("you win");
      
    }
}