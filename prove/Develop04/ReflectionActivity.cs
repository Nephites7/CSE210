using System;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity(int duration) : base(duration, "Reflection Activity")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"Random Prompt: {prompt}");
        Thread.Sleep(3000); // Pause for 3 seconds

        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000); // Pause for 3 seconds
        }

        EndActivity();
    }
}
