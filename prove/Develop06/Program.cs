using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();

        Goal goal = new Goal("eat 4 times a day"," i will do my best to eat atleast 4 times per day for my body to be well fed","67");
        

        SimpleGoals simpleGoal1 = new SimpleGoals("sports","playing basketball 3 times a day","34");

        EternalGoal eternalGoal1 = new EternalGoal("Temple","Visit the Temple 3 Before the year ends","78");

        CheckListGoal checkListGoal1 = new CheckListGoal("youtube video","uploading one youyube video after every 3 days","59");
        Console.WriteLine("you have 0 points");
         while (numberReply != "6")
        Console.WriteLine("Menu Options");
        Console.WriteLine(""+"1.Create New Goal");
        Console.WriteLine(""+"2.List Goals");
        Console.WriteLine(""+"3.Save Goals");
        Console.WriteLine(""+"4.Load Goals");
        Console.WriteLine(""+"5.Record Event");
        Console.WriteLine(""+"6.Quit");

        numberReply = Console.ReadLine();



      
        while (numberReply != "5")
            {
                Console.WriteLine("1.Write");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Load");
                Console.WriteLine("4.Save");
                Console.WriteLine("5.Quit");
                Console.WriteLine("6.Priority reminders");

                numberReply = Console.ReadLine();

                 if (numberReply == "1")
                    {
                        Console.WriteLine("The types of Goals are:");
                        Console.WriteLine("1.Simple Goal");
                        Console.WriteLine("2.Eternal Goal");
                        Console.WriteLine("3.Checklist GOal");

                        Console.WriteLine("Which type of Goal would you like to create");
                        string goalChoice = Console.ReadLine();
                        else if (goalChoice == "1")
                            {
                                Console.WriteLine("type any simple Goal");
                                string simple = Console.ReadLine();
                                simple.RecortEvent();
                               
                            }
                        else if (goalChoice == "2")
                            {
                                Console.WriteLine("type any Eternal Goal");
                                string eternal = Console.ReadLine();
                                Console.WriteLine(eternal.GetStringRepresentation());
                            }
                        else if(goalChoice == "3") 
                                Console.WriteLine("type any simple Goal");
                                string checklist = Console.ReadLine();
                                checklist.RecordEvent();
                          

                  else if (numberReply == "2")
                    {
                        
                        goalManager.ListGoalDetails();
                    }

                 else if (numberReply == "3")
                    {
                        Console.WriteLine("Enter a File Name");
                        string userInput = Console.ReadLine();
                       
                        goalManager.LoadGoals(userInput);

                 else if (numberReply == "4")
                    {
                        Console.WriteLine("whaT is the file name?");
                        string userFileName = Console.ReadLine();
                        
                        goalManager.SaveGoals(userFileName);
                    }

    }    
}