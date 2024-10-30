using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

       GoalManager goalManager = new GoalManager();
        string numberReply = "";

        Console.WriteLine("You have 0 points");

        while (numberReply != "6")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            numberReply = Console.ReadLine();
                if (numberReply == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                Console.WriteLine("Which type of Goal would you like to create?");
                string goalChoice = Console.ReadLine();

                if (goalChoice == "1")
                    {
                      Console.WriteLine("Type your simple goal:");
                      string simpleGoalName = Console.ReadLine();
                      Console.WriteLine("Type the description:");
                      string simpleGoalDescription = Console.ReadLine();
                      Console.WriteLine("Type the points (integer):");
                      int simpleGoalPoints = int.Parse(Console.ReadLine());

                     SimpleGoal simpleGoal = new SimpleGoal(simpleGoalName, simpleGoalDescription, simpleGoalPoints);
                      goalManager.CreateGoal("Simple", simpleGoalName, simpleGoalDescription, simpleGoalPoints);
                    }
                else if (goalChoice == "2")
                    {
                      Console.WriteLine("Type your eternal goal:");
                      string eternalGoalName = Console.ReadLine();
                      Console.WriteLine("Type the description:");
                      string eternalGoalDescription = Console.ReadLine();
                      Console.WriteLine("Type the points (integer):");
                      int eternalGoalPoints = int.Parse(Console.ReadLine());

                       EternalGoal eternalGoal = new EternalGoal(eternalGoalName, eternalGoalDescription, eternalGoalPoints);
                       goalManager.CreateGoal("Eternal", eternalGoalName, eternalGoalDescription, eternalGoalPoints);
                     }
                else if (goalChoice == "3")
                     {
                         Console.WriteLine("Type your checklist goal:");
                         string checklistGoalName = Console.ReadLine();
                         Console.WriteLine("Type the description:");
                         string checklistGoalDescription = Console.ReadLine();
                         Console.WriteLine("Type the points (integer):");
                         int checklistGoalPoints = int.Parse(Console.ReadLine());
                         Console.WriteLine("Type the target:");
                         int checklistTarget = int.Parse(Console.ReadLine());
                          Console.WriteLine("Type the bonus:");
                         int checklistBonus = int.Parse(Console.ReadLine());

                         CheckListGoal checkListGoal = new CheckListGoal(checklistGoalName, checklistGoalDescription, checklistGoalPoints, checklistTarget, checklistBonus);
                         goalManager.CreateGoal("Checklist", checklistGoalName, checklistGoalDescription, checklistGoalPoints, checklistTarget, checklistBonus);
                   }
            }
            else if (numberReply == "2")
                {
                goalManager.DisplayPlayerInfo(); // Change to list details
                }
            else if (numberReply == "3")
                 {
                    Console.WriteLine("Enter a file name to save goals:");
                    string userFileName = Console.ReadLine();
                    goalManager.SaveGoals(userFileName);
                }
            else if (numberReply == "4")
                {
                     Console.WriteLine("What is the file name to load goals?");
                     string userFileName = Console.ReadLine();
                     goalManager.LoadGoals(userFileName);
               }
            else if (numberReply == "5")
                {
                     Console.WriteLine("Which goal do you want to record an event for?");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
               }
        }
    }    
}