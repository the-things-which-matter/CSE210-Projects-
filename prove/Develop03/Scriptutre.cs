public class Scripture
    {
        //i wiill name and connect these for fatatype to make sense
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
            {
                _reference = reference;
                _words = new List<Word>(text.Split(' ').Select(w => new Word(w)));
            }

        public void HideRandomWords(int numberToHide)
            {
                 var rand = new Random();
                 for (int i = 0; i < numberToHide; i++)
                      {
                        int index = rand.Next(_words.Count);
                        _words[index].Hide();
                      }
              
            }

        public string GetDisplayText()
            {
               // Console.WriteLine($"{_reference}:{_words}");
                //string line = Console.ReadLine();
                //return line;

                return $"{_reference.GetDisplayText()}: " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
            }

        public bool IsCompletelyHidden()
            {
               ///foreach (Word sentence in _words)
               // if (sentence =="")
                  //  Console.WriteLine("done");

                  return _words.All(w => w.IsHidden());
            }
    }