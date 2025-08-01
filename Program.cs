using System;
using static YoutubeChannel;

class YoutubeChannel
{

    public class VideoEventArgs : EventArgs
    {
        public string VideoTitle { get; set; }
        public string VideoDescription { get; set; }
      
    }

    public event EventHandler<VideoEventArgs>? VideoUploaded;

    public void UploadVideo()
    {


        VideoUploaded?.Invoke(this, new VideoEventArgs()
        {
            VideoTitle = "C# Advanced Programming",
            VideoDescription = "Learn advanced C# concepts in this video."
        });
    }


    public void UsersSubscribed()
    {
        if (VideoUploaded != null)
        {
            Console.WriteLine("There are subscribers to the channel.");
        }
        else
        {
            Console.WriteLine("There are no subscribers to the channel.");
        }
    }

}




class Person
{
    public string Name;


    public Person(YoutubeChannel channel, string name)
    {

        channel.VideoUploaded += Channel_VideoUploaded;
        Name = name;
    }

    private void Channel_VideoUploaded(object? sender, VideoEventArgs e)
    {
        Console.WriteLine($"Person {Name} has been notiffied with video: {e.VideoTitle}");

    }

    public void Unsubscribe(YoutubeChannel channel)
    {
        channel.VideoUploaded -= Channel_VideoUploaded;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        YoutubeChannel channel = new YoutubeChannel();
        Person person1 = new Person(channel, "Alice");
        channel.UsersSubscribed();
        channel.UploadVideo();
        person1.Unsubscribe(channel);
        channel.UsersSubscribed();
    }
}