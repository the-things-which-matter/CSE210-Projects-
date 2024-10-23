public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity()
            {

            }
        public void Run()
            {

                DisplaySratingMessage();
            }
        public string GetRandomPrompt()
            {
                Random randomGenerator = new Random();
                foreach (string prompt in _prompts)

                return prompt;
            }
        public string GetRandomQuestion()
            {
                Random randomGenerator = new Random();
                foreach (string question in _questions)
                    string result = question;
                return result;
            }
        public void DisplayPrompt()
            {
                Random randomGenerator = new Random();
                foreach (string prompt in _prompts)

                    Console.WriteLine(prompt);

            }
        public void DisplayQuestion()
            {
                Random randomGenerator = new Random();
                foreach (string question in _questions)

                    Console.WriteLine(question)

            }
            
    }
