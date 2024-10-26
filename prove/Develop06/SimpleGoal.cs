public class SimpleGoals : Goal
    {
        private  bool _isComplete;

        public SimpleGoals(string name,string description,string points)
            {
                _name = name;
                _description = description;
                _points = points; 
            }
        public override void RecordEvent()
            {
                $"{goal._shortName},Prompt:{goal._description},Entry Text:{goal._points}");
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