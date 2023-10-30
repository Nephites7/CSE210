class Word
{
    public string Text { get; }
    public int Position { get; }
    public bool IsHidden { get; set; }

    public Word(string text, int position)
    {
        Text = text;
        Position = position;
        IsHidden = false;
    }
}
