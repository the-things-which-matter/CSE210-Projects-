public class Activity
    {
        private int _date;
        protected int _length;

        public Activity(int date, int Length)
            {
                _date = date;
                _length = Length;
            }

        public virtual double GetDistance(int laps)
            {
                return (laps * 50.0) / 1000 * 0.62; 
            }


        public virtual double GetSpeed(double distance, int minutes)
             {
                 return (distance / minutes) * 60; 
             }

            public virtual double GetPace(int minutes, double distance)
                 {
                    return minutes / distance; 
                 }

            public virtual string GetSummary(string date)
                {
                 return $"{date} - Length: {_length} min"; 
                }

        
        
    }