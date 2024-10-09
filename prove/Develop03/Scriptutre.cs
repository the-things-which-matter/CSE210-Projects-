public class Scripture
    {
        //i wiill name and connect these for fatatype to make sense
        private Reference _reference;
        private List<Word> _words;

        public Reference Scriptutre(string text)
            {
                //inhaven't initialise argument(text) to _reference
                return _reference;
            }

        public void HideRandomWords(int numberToHide)
            {
                
               foreach (Word sentence in _words)
                {
                    var rand = new Random();
                string randomWord =_words[rand.Next(_words.Length)];
                }
            }

        public string GetDisplayText()
            {
                Console.WriteLine($"{_reference}:{_words}");
                string line = Console.ReadLine();
                return line;
            }

        public bool IsCompletelyHidden()
            {
               foreach (Word sentence in _words)
                if (sentence =="")
                    Console.WriteLine("done");
            }
    }