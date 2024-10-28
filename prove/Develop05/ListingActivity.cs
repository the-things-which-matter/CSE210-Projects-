public class ListingActivity : Activity
    {
        //private int _count;
        private List<string> _prompts = new List<string>
            {
               "Who are people that you appreciate?",
               "What are personal strengths of yours?",
               "Who are people that you have helped this week?",
               "When have you felt the Holy Ghost this month?",
               "Who are some of your personal heroes?"
             };



        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    
            {
               // foreach (string prompt in _prompts)
                 //   Console.WriteLine(prompt);
            }
        public override void Run()
            
            {
                DisplayStartingMessage();
                
                Random randomGenerator = new Random();
                string prompt = _prompts[randomGenerator.Next(_prompts.Count)];
                Console.WriteLine(prompt);
                ShowCountDown(5); 

                List<string> items = new List<string>();
                Console.WriteLine("Start listing items (type 'done' to finish):");

                DateTime endTime = DateTime.Now.AddSeconds(_duration);
                while (DateTime.Now < endTime)
                   {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "done")
                    break;
                    items.Add(input);
                   }

                    Console.WriteLine($"You listed {items.Count} items.");
                   DisplayEndingMessage();
    }
  }
      