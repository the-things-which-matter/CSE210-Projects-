using System.ComponentModel;

public class Goal
    {
        private string _shortName;
        private string _description;
        private string _points;

        public Goal(string name,string description,string points)
            {
                _shortName = name;
                _description = description;
                _points = points;
            }

        public virtual void RecordEvent()
            {
              string event =  $"{_shortName},{_description},{_points}";
              console.WriteLine(event)
            }
        public virtual bool IsComplete()
            {
                return true;
            }
        public string GetDetailsString()
            {
                return $"{_shortName},{_description},{_points}";
            }
        public virtual string GetStringRepresentation()
            {
                return  _shortName;
            }
    }