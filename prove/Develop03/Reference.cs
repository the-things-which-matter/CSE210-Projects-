public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int?  _endVerse;
        private int _startVerse;

        public Reference(string book, int chapter, int verse)
            {
               _book = book;
              _chapter = chapter;
               _verse = verse;

            }

        public Reference(string book,int chapter,int startVerse, int endVerse)
            {

               _book = book;
              _chapter = chapter;
               _verse = startVerse;
               _endVerse = endVerse;




            }

        public string GetDisplayText()
           // if (_endVerse.HasValue)
            {
            // Console.WriteLine($"{_book} {_chapter} {_startVerse} {_endVerse}");
                    return _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
                //Console.WriteLine(wordi)
                
            }

    }