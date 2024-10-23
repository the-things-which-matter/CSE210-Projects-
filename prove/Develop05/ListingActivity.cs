public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;



        public ListingActivity()
            {
                foreach (string prompt in _prompts)
                    Console.WriteLine(prompt);
            }
        public void Run()
            {
                DisplaySratingMessage();
            }
        public void GetRandomUser()
            {
                Random randomGenerator = new Random();
                foreach (string prompt in _prompts)
                Console.WriteLine(randomGenerator(prompt));

            }
        public List<string> GetListFromUser()
            {
                foreach (string prompt in _prompts)
                return prompt;
            }

    }