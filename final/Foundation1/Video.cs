using System;
using System.Collections.Generic;

public class VideoInfo
{
    private string videoTitle;
    private string uploader;
    private int durationInSeconds;
    private List<UserComment> userComments;

    public VideoInfo(string title, string uploader, int durationInSeconds)
    {
        this.videoTitle = title;
        this.uploader = uploader;
        this.durationInSeconds = durationInSeconds;
        userComments = new List<UserComment>();
    }

    public int GetCommentCount()
    {
        return userComments.Count;
    }

    public void AddUserComment(string commenter, string commentText)
    {
        userComments.Add(new UserComment(commenter, commentText));
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {videoTitle}");
        Console.WriteLine($"Uploader: {uploader}");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}\n");

        Console.WriteLine("User Comments:");
        foreach (var comment in userComments)
        {
            Console.WriteLine($"Commenter: {comment.Commenter}");
            Console.WriteLine($"Text: {comment.CommentText}\n");
        }
    }
}
