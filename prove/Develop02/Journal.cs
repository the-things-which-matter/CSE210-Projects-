using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

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
                       outputFile.WriteLine($"Date:{entry._date},Prompt:{entry._promptText},Entry Text:{entry._entryText}");
                   }
          
                }
            }

        //LoadFromFile method
       public void LoadFromFile(string filename)
           {
               {
                   if (!File.Exists(filename))
                      {
                        Console.WriteLine("File not found");
                        return;
                      }

                       entries.Clear(); // Clear existing entries
                               //indenting 

                       using (StreamReader inputFile = new StreamReader(filename))
                          {
                            string line;
                            while ((line = inputFile.ReadLine()) != null)
                               {
                                  var parts = line.Split('|');
                                  if (parts.Length == 3)
                                      {
                                        Entry entry = new Entry
                                          {
                                           _date = parts[0],
                                           _promptText = parts[1],
                                           _entryText = parts[2]
                                          };
                                          entries.Add(entry);
                                      }
                                }
                          }
               }
                
           }



//PromptGenerator class
//public class PromptGenerator
  //  {
//        private List<string> prompts = new List<string>
         //   {
        
             //   "what made you smile?",
              ///  "what made you frastrated today?",
             //   "How did you see the lord's hand in your life today",
};
        //private Random random = new Random();
       // public string GetRandomPrompt()
           // {
             //   int index = random.Next(prompts.Count);
             //   return prompts[index];
           //// }
 //   }
//}

///real code in prgram.css
/// create instances



///while loop to start code
///



         
