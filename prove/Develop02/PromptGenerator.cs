public class PromptGenerator
    {
        //questions for uisers to answer
        public List<string> _prompts = new List<string>();
        

        //options from which the user chooses
        public List<string> _displayOptions = new List<string>();

        //show a list of prompt for use to pick from
        public string GetRandomPrompt()
            {
                foreach (string screenPrompts in _prompts )
                    {
                        Console.WriteLine(screenPrompts);
                        //string userReturn =Console.ReadLine();
                    }
                return "";
            }

        public string DisplayQuestions(string userChoice)
            {
                
                //foreach (string question in _displayOptions)
                 //   {
                     //   Console.WriteLine(question);
                //    }
                return userChoice;

            }

      //  public class NameGenerator()
        ////    {
              //  private string[] randomQuestion = {"what","now","fone","free","love"};

                   // public string GenerateName()
                      //  {
                       //     var rand = new Random();
                        //    string randomPrompt = randomQuestion[rand.Next(randomQuestion.Length)];

                        //    return $"{randomPrompt}";
                       // }
          //  }
    }