using System.Reflection.Metadata;

public class Entry 
     {
        public string _date = "13/10/2024";
        public string _promptText;
        public string _entryText;

        public string Display()
            {
                Console.WriteLine($"Date:{_date}-Prompt: {_promptText} {_entryText}");
                return "";
                
            }

      }

      