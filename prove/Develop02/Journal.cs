public class Journal
    {
        public List<Entry> _entries;

        //public void AddEntry(Entry newEntry)
            //{

          //  }

            public void DisplayAll()
                {
                      
                }

            public void SaveToFile(string file)
                {
                      using(StreamWriter outPutFile = new StreamWriter(file))
                         foreach (Entry text in _entries)
                        {
                            outPutFile.WriteLine(text);
                        }
                }

            public string LoadFile(string file)
                {
                    foreach (Entry words in _entries)
                       string [] lines = System.IO.file.ReadAllLines(file);

                     return words;
                }
    }
