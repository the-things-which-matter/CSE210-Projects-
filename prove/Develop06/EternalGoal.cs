public class EternalGoal : Goal
    {
        public EternalGoal(string name,string description,string points) 
            {
                _name = name;
                _description = description;
                _poitns = points;
            }

        public override void RecordEvent()
            {
                
                Console.WriteLine(EternalGoal)
            }
        public override bool IsComplete()
            {
                return true;
            }
        public override string GetStringRepresentation()
            {
                return $"{_shortName},{_descriptio},{_points}";
            }
    }