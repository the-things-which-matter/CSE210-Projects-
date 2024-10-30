public class CheckListGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public CheckListGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
                  {
                   _target = target;
                   _bonus = bonus;
                   _amountCompleted = 0; 
                  }
        //public string GetDetailString()
          //  {
           //     return _decription;
           // }
         public override void RecordEvent()
              {
                _amountCompleted++;
                Console.WriteLine($"{_shortName}, Prompt: {_description}, Entry Text: {_points}");
              }
        
        public override bool IsComplete()
            {
               return _amountCompleted >= _target;
            }
        public override string GetStringRepresentation()
                {
                return $"{_shortName},{_description},{_points},{_amountCompleted}/{_target}";
                }
    }