using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Mathew", "1", "20");
        Reference reference1 = new Reference("Luke", "11", "5");
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(reference, "But while contemplating these things, behold, the angel of the Lord appeared to him in a dream and said, 'Joseph, son of David, do not be afraid to take Mary as your wife, for the child conceived in her is from the Holy Spirit.'"),
            new Scripture(reference1, "And Jesus said to them, 'Which of you who has a friend will go to him at midnight and say to him, 'Friend, lend me three loaves.'")
        };

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            selectedScripture.Display();

            Console.WriteLine("Press the enter key to continue or type 'end' to close:");
            string input = Console.ReadLine();

            if (input.ToLower() == "end")
                break;
            selectedScripture.HideRandomWord();
        }
    }
}


