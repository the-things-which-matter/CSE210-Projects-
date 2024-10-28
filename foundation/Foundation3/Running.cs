public class Running : Activity
    {
         private int _distance;
        private int _speed;
        private int _laps;






         public Running(int distance,int speed,int laps)
            {
                _distance = distance;
                _speed =speed;
                _laps = laps;
            }



        public override int  GetDistance(int laps)
            {
                int dis = (laps * 50) / 1000;
                return dis;
            }
        public override int  GetSpeed(int distance,int minutes)
            {
                 int speed = (distance / minutes) * 60;
                return speed;
            }
        public override int  GetPace(int minutes,int distance)
            {
                int pace = minutes / distance;
                return pace;
            }
        
        public override string GetSummary(string date, string minutes, int distance, int speed, int pace)
            {
                return $"{date} {minutes} distance is {distance}miles,Speed{speed}mph,Pace:{pace} min per mile"; 
            }

      
    }