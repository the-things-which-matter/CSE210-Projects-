public class CheckListGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public CheckListGoal(string name, string description,string points) base (name,description)
            {
                _name = name;
                _description = description;
                _points -= points;
            }
        public string GetDetailString()
            {
                return _decription;
            }
        public override void RecordEvent()
            {
                
                $"{goal._shortName},Prompt:{goal._description},Entry Text:{goal._points}";
                   }
            }
        public override bool IsComplete()
            {
                return true;
            }
        public override string GetStringRepresentation()
            {
               return $"{_shortName},{_descriptio},{_points}";;
            }
    }