public class PromptGenerator
    {
        public List<string> _prompts = new List<string>();

        public string GetRandomPrompt()
            {
                foreach (string screenPrompts in _prompts )
                    {
                        Console.WriteLine(screenPrompts);
                        //string userReturn =Console.ReadLine();
                    }
                return "";
            }

        public class NameGenerator()
            {
                private string[] randomQuestion = {"what","now","fone","free","love"};

                    public string GenerateName()
                        {
                            var rand = new Random();
                            string randomPrompt = randomQuestion[rand.Next(randomQuestion.Length)];

                            return $"{randomPrompt}";
                        }
            }
    }