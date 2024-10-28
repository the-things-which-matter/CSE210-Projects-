public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
        private List<string> _questions = new List<string>
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };

        public ReflectingActivity() :base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    
            {

            }
        public override void Run()
            {

                DisplayStartingMessage();
                //DisplayStartingMessage();
                Random randomGenerator = new Random();
                string prompt = _prompts[randomGenerator.Next(_prompts.Count)];
                Console.WriteLine(prompt);
                ShowCountDown(5); 

                int durationInSeconds = _duration;
                while (durationInSeconds > 0)
                    {
                     string question = _questions[randomGenerator.Next(_questions.Count)];
                     Console.WriteLine(question);
                     ShowSpinner(5); 
                     durationInSeconds -= 5; 
                    }
                   DisplayEndingMessage();
    }
          
            
    }
