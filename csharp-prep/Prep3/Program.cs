using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is my Prep 3 Project");

        Random randomNumberGenerate = new Random();
        int realNumber = randomNumberGenerate.Next(1,95);

        int magicNumber = 0;

        while (magicNumber != realNumber)
            {
                Console.Write("Enter youur guess ");
                magicNumber = int.Parse(Console.ReadLine());

                if (realNumber > magicNumber)
                    {
                        Console.WriteLine("Higher");

                    }
                else if (realNumber < magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                else
                {
                    {
                        Console.WriteLine("You guessed it");
                    }
                }
            }
        Console.WriteLine("End of Prep 3 Project");
       
    }
}