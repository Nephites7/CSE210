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
        CountDown(5); // wait
        int count = 0;

        while (duration > 0)
        {
            count++;
            Console.WriteLine($"Item {count}:");
            Spinner(5); // wait
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}
