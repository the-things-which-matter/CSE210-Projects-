using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is My Prep 2 Project");
        Console.Write("Please enter your percentage score ");
        string score = Console.ReadLine();
        //Console.WriteLine(score);

        // changing the score to integer
        int studentScore = int.Parse(score);

        string examLetter = "";
        if (studentScore >= 90)
            {
                examLetter = "A";
            }

        else if (studentScore >= 80)
            {
                 examLetter = "B";
            }
       else if (studentScore >= 70)
            {
                 examLetter = "C";
            }
        else if (studentScore >= 60)
            {
                 examLetter = "D";
            }
        else 
            {
                 examLetter = "F";
            }

            //Determining whether the student has passed or not
            //string newScore = studentScore.ToString();
        Console.WriteLine($"your grade is {examLetter}");
        if (studentScore >= 70)
            {
                Console.WriteLine("CONGRATULATIONS. You passed your Exams.");
            }

        else
            {
                Console.WriteLine("Sorry, it is sad that you didn't pass your Exams, you can do a retake and try again");
            }


    }
}