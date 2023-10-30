class Scripture
{
    private Reference reference;
    private string text;
    private List<string> hiddenWords;

    public Scripture(Reference reference, string text)
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
        Console.WriteLine($"{reference._book},{reference._chapter},{reference._verse}: {displayedText}");
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