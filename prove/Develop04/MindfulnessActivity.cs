using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration;
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
        Spinner(3); // Pause for 3 seconds
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {description} activity for {duration} seconds.");
        Spinner(3); // Pause for 3 seconds
    }

    public abstract void PerformActivity();

    protected void CountDown(int seconds) 
    {
        while (seconds > 0)
        {
            Console.Write(seconds); // display time left in seconds
            Thread.Sleep(1000);      // wait...
            Console.Write("\b \b"); // remove previous character
            seconds --;             // time has passed so decrement seconds
        }
    }

    protected void Spinner(int seconds)
    {
        while (seconds > 0) {
            Console.Write("-");     // Display first part of the animation
            Thread.Sleep(245);      // wait for 1/4 of a second
            Console.Write("\b \b"); // Remove previous character

            Console.Write("\\");
            Thread.Sleep(245);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(245);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(245);
            Console.Write("\b \b");

            seconds --;         // one second has passed
        }
    }
}
