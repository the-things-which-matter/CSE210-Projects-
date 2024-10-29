using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Cycling cycle = new Cycling(234,46,23);

        Running run = new Running(467,234,76);

        Swimming swim = new Swimming(345,75,12);

        List<Activity> _activities = new List<Activity>();
        _activities.Add(cycle);
        _activities.Add(run);
        _activities.Add(swim);
        
        foreach (Activity activity in _activities)
            Console.WriteLine(activity.GetSummary("03 Nov 2022"));
       

    }
}