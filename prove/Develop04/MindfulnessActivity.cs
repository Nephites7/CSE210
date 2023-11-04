using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    private int duration;
    private string description;
    protected string[] prompts;
    protected string[] reflectionQuestions;

    public MindfulnessActivity(int duration, string description)
    {
        this.duration = duration;
        this.description = description;

        prompts = new string[]
        {
            "Think of a time when you stood up for another person",
            "Think of a time when you overcame a difficult situation",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        reflectionQuestions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you start?",
            "How did you feel when it was finished?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void StartActivity()
    {
        Console.WriteLine($"-- {description} --");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {description} activity for {duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public abstract void PerformActivity();
}
