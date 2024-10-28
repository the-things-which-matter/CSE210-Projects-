public class Activity
    {
        private string _name;
        private string _description;
        protected int _duration;

        public Activity(string name, string description)
            {
                _name = name;
                _description = description;
            }
        public void DisplayStartingMessage()
            {
                Console.WriteLine("welcome to the Breathing exercise game");
                Console.WriteLine($"Welcome to the {_name}.");
                Console.WriteLine(_description);
                Console.Write("Please enter the duration in seconds: ");
                _duration = int.Parse(Console.ReadLine());
                Console.WriteLine("Get ready...");
                ShowSpinner(3);
            }
        public void DisplayEndingMessage()
            {
                Console.WriteLine("Thanks for your time to do the breathing exercise");
                Console.WriteLine("Good job! You've completed the activity.");
                Console.WriteLine($"You spent {_duration} seconds on this activity.");
                ShowSpinner(3);
            }
        public void ShowSpinner(int seconds)
            {
                for (int i = 0; i < seconds; i++)
                      {
                        Console.Write("\r|");
                        Thread.Sleep(250);
                        Console.Write("\r/");
                        Thread.Sleep(250);
                        Console.Write("\r-");
                        Thread.Sleep(250);
                        Console.Write("\r\\");
                        Thread.Sleep(250);
                      }
                     //Console.WriteLine();
            }
        public void ShowCountDown(int seconds)
            {
                for (int i = seconds; i > 0; i--)
                    {
                      Console.Write($"\r{i} seconds remaining...");
                      Thread.Sleep(1000);
                    }
                    // Console.WriteLine();
            }
         public virtual void Run() 
            {
                
             }

    }