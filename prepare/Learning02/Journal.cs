public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        

        public void AddEntry(string newEntry)
            {
                if(newEntry == "2")
                    {
                       Console.WriteLine("Hello");
                    }
            }
        
        public void DisplayAll()
            {
                 string[] prompts = {"1.wite","2.Display","3.Load","4.Load","5.Quit"};
                  foreach (string prompt in prompts)
                    {
                         Console.WriteLine(prompt);
                         string newEntry = Console.ReadLine();
                    }

       
            }
        public void SaveToFile(string file)
            {

            }

        public void LoadFromFile(string file)
            {
                
            }
    }
