using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;




//firts class

//journal class
public class Journal 
    {
        private List<Entry> entries = new List<Entry>();
                    
        //AddEntry Method
        public void AddEntry(Entry entry)
            {
                entries.Add(entry);
            }

        //DisplayEntry Method
        public void DisplayEntries()
            {
                if (entries.Count == 0)
                    {
                        Console.WriteLine("No entries");
                        return;
                    }

                foreach (var entry in entries)
                    {
                        entry.Display();
                    }
            }

         //SaveTo file method
        public void SaveToFile(string filename)
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                

            {
             foreach (Entry entry in entries )
           {
              outputFile.WriteLine(entry._date);
           }
           // You can add text to the file with the WriteLine method
             outputFile.WriteLine("promt:{}");
    
          // You can use the $ and include variables just like with Console.WriteLine
           string color = "Blue";
           outputFile.WriteLine($"My favorite color is {color}");
             }
            }

        //LoadFromFile method
        public void LoadFromFile(string filename)
            {
                if (!File.Exists(filename))
                    {
                        Console.WriteLine("file not found");
                        
                    }
                
            }



//PromptGenerator class
public class PromptGenerator
    {
        private List<string> prompts = new List<string>
            {
        
                "what made you smile?",
                "what made you frastrated today?",
                "How did you see the lord's hand in your life today",
            };
        private Random random = new Random();
        public string GetRandomPrompt()
            {
                int index = random.Next(prompts.Count);
                return prompts[index];
            }
    }
}

///real code in prgram.css
/// create instances



///while loop to start code
///



         
