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
        Console.WriteLine("This activity will help you relax by guiding you through deep breathing! Ensure you are free from any distactions!");
        Console.WriteLine("Please, clear your mind and focus on your breath.");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Breathe in...");
            CountDown(5); // Pause for 4 second
            Console.WriteLine();
            Console.Write("Breathe out...");
            CountDown(5);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }
        EndActivity();
    }
}
