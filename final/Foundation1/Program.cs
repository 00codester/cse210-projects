using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video vid1 = new Video("Would You Swim With Sharks For $100,000?", "MrBeast", 540);
        vid1.AddComment("Johnny Sins", "Mrbeast needs his own show at this point");
        vid1.AddComment("Daniele Mota", "Jimmy keep doing good for people who need help from you.");
        vid1.AddComment("Sanya Srijumlong 003", "Your content is very enjoyable");
        vid1.AddComment("Elmo Alvaro", "your team was so funny Mr. Beast! keep up and more blessings to you and your team!");
        Video vid2 = new Video("SELLING SOME CORN! | Among Us: Town of Us", "Dooley Noted", 14040);
        vid2.AddComment("BlitzofChaos Gaming", "Starting off on a Hmmmmmm Courtilly is going to definitely be getting some revenge moment.");
        vid2.AddComment("lali popz", "That Peter griffin skin is wild az lmao");
        vid2.AddComment("DLeeGriff", "Really looking forward to that new Corn album by Jeremy");
        Video vid3 = new Video("Getting A Job In Tech is Harder Than You Think", "Bukola", 570);
        vid3.AddComment("J", "The only real and honest influencer in tech");
        vid3.AddComment("serendipity", "You're a blessing... I love your tips and videos.... it's going to be hard, but there's no way I am giving up");
        vid3.AddComment("The Climb Project", "Love that you break it down to individual tips, would love to hear a long form version of this topic!");
        vid3.AddComment("Eric", "I'm in a coding camp in NYC and this info is very helpful, keep it coming");

        _videos.Add(vid1);
        _videos.Add(vid2);
        _videos.Add(vid3);

        foreach (Video video in _videos){
            video.DisplayVideo();
        }
    }
}