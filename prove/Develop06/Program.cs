using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("yo");
        string  num ="2";
        Console.WriteLine("enter name");
        string name = Console.ReadLine();

         Console.WriteLine("enter free");
        string free = Console.ReadLine();
        //++num;
        Console.WriteLine($"brigha hates {free}");
        Console.WriteLine($"{name} is a robot");
        int nem = int.Parse(num);

        int [] _arrays ={2,6,6};
        Console.WriteLine(_arrays[2]);
        _arrays[3] = 4;

        string [] people = new string[3];
        people[0] = "qen";
        people[1] = "ten";

        
    }
}