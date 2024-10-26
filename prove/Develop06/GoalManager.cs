using System.Runtime.CompilerServices;

public class GoalManager
    {
        private List<Goal> _goal;
        private int _score;

        public GoalManager()
            {
                foreach(Goal goal in _goal)
                    {
                        Console.WriteLine(goal);
                    }
            }

        public void Start()
            {
                Console.WriteLine("choose one of the following");
            }
        public void DisplayPlayerInfo()
            {
                string goal = _goal;
                Console.WriteLine(goal);
            }
        public void ListGoalNames()
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1.Simple Goal");
                Console.WriteLine("2.Eternal Goal");
                Console.WriteLine("3.Checklist GOal");

            }
        public void ListGoalDetails()
            {
                $"Date:{goal._shortName},Prompt:{goal._description},Entry Text:{goal._points}");
                   
            }
        public void CreatGoal()
            {
                goal.description;
            }
        public void RecordEvent()
            {
               string goal = $" the goals are{_goal}";
               Console.WriteLine(goal);
            }
        public void SaveGoals()
            {
                      using (StreamWriter outputFile = new StreamWriter(filename))
                

               {
                  foreach (Goal goal in _goal )
                   {
                       outputFile.WriteLine($"Date:{goal._shortName},Prompt:{goal._description},Entry Text:{goal._points}");
                   }
          
                }
            }
        public void LoadGoals()
            {
                if (_goal.Count == 0)
                  {
                     Console.WriteLine("No goals");
                     return;
                  }

                  foreach (var goal in _goal)
                    {
                       goal.GetDetailsString();
                    }
            }

    }