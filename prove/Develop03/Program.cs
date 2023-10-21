using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("Matthew 1:20", "But while contemplating these things, behold, the angel of the Lord appeared to him in a dream and said, 'Joseph, son of David, do not be afraid to take Mary as your wife, for the child conceived in her is from the Holy Spirit.'"),
            new Scripture("Luke 11:5", "And Jesus said to them, 'Which of you who has a friend will go to him at midnight and say to him, 'Friend, lend me three loaves.'")
        };

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            selectedScripture.Display();

            Console.WriteLine("Press the enter key to continue or type 'end' to close:");
            string input = Console.ReadLine();

            if (input.ToLower() == "end")
                break;
            selectedScripture.HideRandomWord();
        }
    }
}

class Scripture
{
    private string reference;
    private string text;
    private List<string> hiddenWords;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        hiddenWords = new List<string>();
    }

    public void Display()
    {
        string displayedText = text;
        foreach (string word in hiddenWords)
        {
            displayedText = displayedText.Replace(word, new string('_', word.Length));
        }
        Console.WriteLine($"{reference}: {displayedText}");
    }

    public void HideRandomWord()
    {
        List<string> wordsToHide = text.Split(' ').Where(word => !hiddenWords.Contains(word)).ToList();
        if (wordsToHide.Count > 0)
        {
            Random random = new Random();
            string wordToHide = wordsToHide[random.Next(wordsToHide.Count)];
            hiddenWords.Add(wordToHide);
        }
    }
}
