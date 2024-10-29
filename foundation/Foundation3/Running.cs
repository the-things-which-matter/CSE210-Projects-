public class Running : Activity
    {
        private double _distance; // in miles

    public Running(int date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetSummary(string date)
    {
        double speed = GetSpeed(_distance, _length);
        double pace = GetPace(_length, _distance);
        return $"{date} Running ({_length} min) - Distance: {_distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
      
    }