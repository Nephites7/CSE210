using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration, "Breathing Activity")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        Console.WriteLine("This activity will help you relax by guiding you through deep breathing.");
        Console.WriteLine("Clear your mind and focus on your breath.");
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000); // Pause for 1 second
        }
        EndActivity();
    }
}
