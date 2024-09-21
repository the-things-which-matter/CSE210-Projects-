using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Prep 5 Project");
        DisplayWelcomeMesage();

        string userName = PromptUser();
        int userNumber = PromptUserNumber();

        int squaredNumber =  SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }


    static void DisplayWelcomeMesage()
        {
            Console.WriteLine("Welcome tp the Program!");
        }

    static string PromptUser()
        {
            Console.Write("Please Enter your name");
            string name = Console.ReadLine();
            return name;
        }

    static int PromptUserNumber()
        {
            Console.Write("Enter your Favorite Number");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

    static int SquaredNumber(int number)
        {
            int squaring =number * number;
            return squaring;
        }

    static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"The Square pf yopur Number is {square}");
        }
}