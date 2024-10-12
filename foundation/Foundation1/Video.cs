using System.Transactions;

public class Video
    {
        private string _title;
        private string _authour;
        private int _lengthInSeconds;
        private List<Comment> _comments = new List<Comment>();
        public Video(string title, string author, int legthInSecond)
            {
                _title = title;
                _authour = author;
                _lengthInSeconds = legthInSecond;
            }

        public void AddComment(Comment comment)
            {
                _comments.Add(comment);
            }

        public int GetNumberOfComment()
            {
                foreach (Comment oneComment in _comments)
                    {
                        int commentNumber = _comments.le
                    }
                return;
            }
        public string GetVideoDetails()
            {
                return "";
            }

        public void DisplayComments()
            {

            }

    }