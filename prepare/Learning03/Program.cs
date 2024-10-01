using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction firstFraction = new Fraction();
        Console.WriteLine(firstFraction.GetFractionString());
        Console.WriteLine(firstFraction.GetDecimalValue());


        Fraction secondFRaction = new Fraction(5);
        Console.WriteLine(secondFRaction.GetFractionString());
        Console.WriteLine(secondFRaction.GetDecimalValue());

        Fraction thirdFraction = new Fraction(3,4);
        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());

        Fraction fourthFraction = new Fraction(1,3);
        Console.WriteLine(fourthFraction.GetFractionString());
        Console.WriteLine(fourthFraction.GetDecimalValue());

        //Console.WriteLine("what is your name");
        //string name = Console.ReadLine();
        //Console.WriteLine($"Your name is:{name}");


        
    }
}