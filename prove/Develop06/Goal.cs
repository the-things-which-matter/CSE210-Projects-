using System.ComponentModel;

public class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string name,string description,int points)
            {
                _shortName = name;
                _description = description;
                _points = points;
            }

        public virtual void RecordEvent()
            {
              string eventDetails =  $"{_shortName},{_description},{_points}";
              Console.WriteLine(eventDetails);
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