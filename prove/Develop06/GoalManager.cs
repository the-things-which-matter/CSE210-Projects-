using System.Runtime.CompilerServices;

public class GoalManager
    {
        private List<Goal> _goals;
        private int _scores;

         public GoalManager()
            {
            _goals = new List<Goal>();
           _scores = 0;
           }


        public void Start()
           {
            Console.WriteLine("Choose one of the following:");
            ListGoalNames();
           }
        public void DisplayPlayerInfo()
           {
            foreach (Goal goal in _goals)
              {
               Console.WriteLine(goal.GetDetailsString());
              }
          }
        public void ListGoalNames()
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1.Simple Goal");
                Console.WriteLine("2.Eternal Goal");
                Console.WriteLine("3.Checklist GOal");

            }

         public void CreateGoal(string type, string name, string description, int points, int target = 0, int bonus = 0)
             {
              Goal newGoal;
               if (type == "Simple")
                   {
                    newGoal = new SimpleGoal(name, description, points);
                   }
               else if (type == "Eternal")
                   {
                   newGoal = new EternalGoal(name, description, points);
                   }
               else if (type == "Checklist")
                   {
                   newGoal = new CheckListGoal(name, description, points, target, bonus);
                   }
              else
                  {
                  throw new ArgumentException("Invalid goal type.");
                  }

                 _goals.Add(newGoal);
    }
        
                public void RecordEvent(string goalName)
              {
                 foreach (Goal goal in _goals)
                      {
                      if (goal.GetStringRepresentation() == goalName)
                      {
                       goal.RecordEvent();
                       break;
                      }
                      }
              }
        public void SaveGoals(string filename)
              {
               using (StreamWriter outputFile = new StreamWriter(filename))
                 {
                  foreach (Goal goal in _goals)
                     {
                       outputFile.WriteLine(goal.GetDetailsString());
                     }
                }
             }

        public void LoadGoals(string filename)
             {
             if (_goals.Count == 0)
                {
                Console.WriteLine("No goals");
                return;
                }

               foreach (var goal in _goals)
               {
               Console.WriteLine(goal.GetDetailsString());
               }
        }
}
       