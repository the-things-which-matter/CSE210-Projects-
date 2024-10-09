public class Word
     {
        private string[] _text = new string[]{"if","ye","love","me","keep","my","commandments"};
        private bool _isHidden;

        public  Word(string text)
    
            {
                foreach (string clear in _text)
                {
                    _text =clear;
                }
            
            }

        public void Hide()
            {
                var rand = new Random();
                string randomWord =_text[rand.Next(_text.Length)];
            }

        public void Show()
            {
                foreach (string newText in _text)
                    {
                        Console.WriteLine(newText);
                    }

            }

        public bool IsHidden()
            {
                //check this out/confirm
                return _isHidden;
            }

        public string GetDisplayText()
            {
                //i need a return
            }
     }