using System;
using System.Collections.Generic;

class AppEntryPoint
{
    static void Main()
    {
        var content1 = new VideoInfo("Introduction to Programming", "CodeCraft", 300);
        content1.AddUserComment("LearnerA", "Awesome tutorial!");
        content1.AddUserComment("CoderB", "Very clear explanations.");

        var content2 = new VideoInfo("Web Development Journey", "WebMaven", 400);
        content2.AddUserComment("DeveloperX", "Great job on this series!");
        content2.AddUserComment("CoderY", "I found this very helpful.");

        var content3 = new VideoInfo("Data Science Insights", "DataWizard", 600);
        content3.AddUserComment("AnalyticsFan", "Impressive insights!");
        content3.AddUserComment("ScientistZ", "Can't wait for more content.");

        var videoContentList = new List<VideoInfo> { content1, content2, content3 };

        // Display video information
        foreach (var content in videoContentList)
        {
            content.DisplayVideoDetails();
        }
    }
}
