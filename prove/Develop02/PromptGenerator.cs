public class PromptGenerator
    {
        
        public List<string> _prompts = new List<string>();
        

        
        //public List<string> _displayOptions = new List<string>();

       
        private Random random = new Random();
        public string GetRandomPrompt()
            {
                int index = random.Next(_prompts.Count);
                return _prompts[index];
            }


    }