public class Categories
    {
        public string _bible;
        public string _bookOfMormon;
        public string _PearlOfGreatPrice;
        public string _DoctrineAndCovenants;

        public void ImportantScriptureReminder()
            {
                Console.WriteLine($"The following are areas to consider as yoi save in your Journal: {_bible}, {_bookOfMormon}, {_PearlOfGreatPrice}, {_DoctrineAndCovenants}");
            }
    }