using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    public ListingActivity(int duration) : base(duration, "Listing Activity")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"Random Prompt: {prompt}");
        Thread.Sleep(3000); // Pause for 3 seconds
        int count = 0;

        while (duration > 0)
        {
            count++;
            Console.WriteLine($"Item {count}:");
            Thread.Sleep(3000); // Pause for 3 seconds
            duration -= 3; // Each item takes 3 seconds
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}
