class LectureEvent : Event
{
    private string speakerName;
    private int capacity;

    public LectureEvent(string name, string description, DateTime date, DateTime time, EventAddress address, string speaker, int capacity)
        : base(name, description, date, time, address)
    {
        speakerName = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speakerName}\nCapacity: {capacity}";
    }
}
