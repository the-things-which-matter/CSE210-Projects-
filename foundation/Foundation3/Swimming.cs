public class Swimming : Activity
    {

        private int _laps;

        public Swimming(int date, int length, int laps) : base(date, length)
              {
                _laps = laps;
              }

        public override string GetSummary(string date)
             {
              double distance = GetDistance(_laps);
              double speed = GetSpeed(distance, _length);
              double pace = GetPace(_length, distance);
              return $"{date} Swimming ({_length} min) - Distance: {distance:F1} miles, Speed: {speed:F1} mph, Pace: {pace:F2} min per mile";
            }

    }