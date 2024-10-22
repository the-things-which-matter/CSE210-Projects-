using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        //Comment comment = new Comment("Brian", "I don't like the pacing of the video");

        Video specificVideo1 = new Video("The Lost Sheep","James Kirb",56);
        specificVideo1.AddComment(new Comment("Brian", "I don't like the pacing of the video"));
        specificVideo1.AddComment(new Comment("Sarah", "Interesting video"));
        specificVideo1.AddComment(new Comment("Tom", "The previous video was better"));
        specificVideo1.AddComment(new Comment("Emma", "You are getting better with each video"));
        videos.Add(specificVideo1);
        //List<Comment> vid1 = new List<Comment>();
        

        Video specificVideo2 = new Video("Way Back home","George Griffen",47);
        specificVideo2.AddComment(new Comment("Bruno","I don't like this video"));
        specificVideo1.AddComment(new Comment("sarah","The video was very short"));
        videos.Add(specificVideo2);

        Video specificVideo3 = new Video("Think Twice","Huskin Lambs",52);
        specificVideo3.AddComment(new Comment("Nick","improve your lighting"));
        specificVideo1.AddComment(new Comment("Alonzo","I like your audio, it's great"));
        videos.Add(specificVideo3);

        foreach (Video singleVideo in videos)
            {
                Console.WriteLine(singleVideo.GetVideoDetails());
                Console.WriteLine($"The number of comments is {singleVideo.GetNumberOfComment()}");
                singleVideo.DisplayComments();
            }

        //Comment theComments = new Comment();
        
        
    }
}