public class Activity
    {
        private int _date;
        private int _length;

        public Activity(int date, int Length)
            {
                _date = date;
                _length = Length;
            }

        public virtual int GetDistance(int laps)
            {
                int distance = (laps * 50) / 1000;
                return distance;
            }
        public virtual int GetSpeed(int distance, int minutes)
            {
                int speed = (distance / minutes) * 60;
                return speed;
            }
        public virtual int  GetPace(int minutes, int distance)
            {
                int pace = minutes / distance;
                return pace;
            }
        
        public virtual string GetSummary(string date, string minutes, int distance, int speed, int pace)
            {
                return $"{date} {minutes} -Distance{distance}miles,Speed{speed}mph,Pace:{pace} min per mile"; 
            }
    }