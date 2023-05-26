using System;

class Program
{
    static void Main(string[] args)
    {   List<Video> videoList = new List<Video>();

        // first video and comments
        Comment comment1Video1 = new Comment("MrRoberto", "This song is so overplayed and annoying!!!");
        Comment comment2Video1 = new Comment("Gma Nan", "MY GRANDSON IS SO CUTE WHEN HE DANCES TO THIS VIDEO :)");
        Comment comment3Video1 = new Comment("HirschMicki26", "Ich weiss nicht einmal wie ich hierher gelandet bin...");
        Video video1 = new Video("Baby Shark Doo Doo Doo 60 min", "Baby Shark Official", 3600, comment1Video1, comment2Video1, comment3Video1);

        videoList.Add(video1);

        // second video and comments
        Comment comment1Video2 = new Comment("ScootMan97", "I love me a good Harley Softail");
        Comment comment2Video2 = new Comment("BigTom2023", "thing aint even a mortersicle its a scuter");
        Comment comment3Video2 = new Comment("Kare bear", "these r just stupid & dangerous! they always drive thru my neigborhood, & they r so loud! u should stay away from them!!!");
        Comment comment4Video2 = new Comment("DaddyDave1961", "Harleys are cool, but I love the Honda Magna. Classic!");
        Video video2 = new Video("2022 Harley Davidson Softail Standard 107 First Ride | REVIEW", "Jawline Rider", 759, comment1Video2, comment2Video2, comment3Video2, comment4Video2);

        videoList.Add(video2);

        // third video and comments
        Comment comment1Video3 = new Comment("[ SaeNekoKun ]", "The fact that people prefer vine more than tiktok really puts my heart at ease. Humanity restored.");
        Comment comment2Video3 = new Comment("Shame on Becky's Ex", "I imagine when we're all old and grey in the nursing home, and our memories are completely shot,\n" +
        "we'll still just be constantly quoting vines at one another");
        Comment comment3Video3 = new Comment("Pigeon ID", "Vine was so ahead of its time... such a shame it's gone.");
        Comment comment4Video3 = new Comment("unpopular opinion", "The fact that every single vine lives rent free in my head after all these years , i really miss it");
        Video video3 = new Video("Vines that cure my anxiety", "Elegant Panda Ninja", 882, comment1Video3, comment2Video3, comment3Video3, comment4Video3);

        videoList.Add(video3);
        
        foreach(Video video in videoList)
        {
            Console.WriteLine(($"{video._title}  -  {video._author} ({video._lengthInSeconds} seconds), {video.CommentsNumber()} comments\n\nComments:"));
            
            foreach(Comment comment in video._commentsList)
            {
                Console.WriteLine(comment.FormatComment());
            }

            Console.WriteLine("\n \n");
        }
        


    }
}
