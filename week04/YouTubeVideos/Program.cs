using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Traditional Zulu Dance Performance", "CulturalHeritage TV", 320);
        v1.AddComment(new Comment("Dullar", "The energy and rhythm are incredible!"));
        v1.AddComment(new Comment("GlobalTraveler", "I saw this live in Durban."));
        v1.AddComment(new Comment("Japesa", "The drumming is so powerful."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Morning Safari in Kruger National Park", "WildAfrica Safari", 1500);
        v2.AddComment(new Comment("SafariFanatic", "Seeing that leopard was amazing."));
        v2.AddComment(new Comment("NaturePhotos", "Perfect lighting at sunrise."));
        v2.AddComment(new Comment("KidsLoveAnimals", "My son loved the elephants!"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Victoria Falls: The Smoke That Thunders", "ExploreTheWorld", 600);
        v3.AddComment(new Comment("ZambiaPride", "Joseph John is beautiful."));
        v3.AddComment(new Comment("AdrenalineJunkie", "The bungee jump is a must-do!"));
        v3.AddComment(new Comment("MistSeeker", "I can almost feel the spray."));
        videos.Add(v3);

        // Display results
        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Title:  {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment._name}: {comment._text}");
            }
        }
    }
}