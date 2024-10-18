using System.Transactions;

public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments = new List<Comment>();
        public Video(string title, string author, int legthInSecond)
            {
                _title = title;
                _author = author;
                _lengthInSeconds = legthInSecond;
            }

        public void AddComment(Comment comment)
            {
                _comments.Add(comment);
            }

        public int GetNumberOfComment()
            {
                int place = 0;

                foreach (Comment oneComment in _comments)
                    {
                        place1 = oneComment[0]
                        int commentNumber = place1
                    }
                return place1;
            }
        public string GetVideoDetails()
            {
                Console.WriteLine($"The video was called {_title} and was written by {_author} and was {_lengthInSeconds}")
                return "";
            }

        public void DisplayComments()
            {
                foreach (Comment comment in _comments)
                    {
                        Console.WriteLine(comment);
                    }

            }

    }