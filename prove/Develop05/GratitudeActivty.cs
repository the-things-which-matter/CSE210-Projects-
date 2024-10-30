public class GratitudeActivity : Activity
{
    public GratitudeActivity() 
        : base("Gratitude Activity", "This activity will help you ponder and be gratefull of some of the things in your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        List<string> items = new List<string>();
        Console.WriteLine("Think of things you are grateful for.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"You listed {items.Count} things you are grateful for.");
        DisplayEndingMessage();
    }
}