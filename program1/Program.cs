using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "How to Make Pancakes",
            "Cooking Channel",
            300
        );

        video1.AddComment(
            new Comment("Jake", "This was really helpful")
        );

        video1.AddComment(
            new Comment("Mia", "I tried this and it worked")
        );

        video1.AddComment(
            new Comment("Sam", "The pancakes looked good")
        );

        videos.Add(video1);

        Video video2 = new Video(
            "Beginner Guitar Lesson",
            "Music Teacher",
            480
        );

        video2.AddComment(
            new Comment("Chris", "This helped me learn my first chord")
        );

        video2.AddComment(
            new Comment("Alex", "Can you make another lesson")
        );

        video2.AddComment(
            new Comment("Taylor", "Very easy to understand")
        );

        videos.Add(video2);

        Video video3 = new Video(
            "Easy Home Workout",
            "Fitness Guide",
            600
        );

        video3.AddComment(
            new Comment("Jordan", "This workout was harder than I expected")
        );

        video3.AddComment(
            new Comment("Emily", "I liked the exercises")
        );

        video3.AddComment(
            new Comment("Noah", "I am going to do this every day")
        );

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}