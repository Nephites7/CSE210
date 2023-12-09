class LectureEvent : Event
{
    private string speaker;
    private int capacity;

    public LectureEvent(string name, string description, DateTime date, DateTime time, EventAddress address, string speaker, int capacity)
        : base(name, description, date, time.TimeOfDay, address) // Convert DateTime to TimeSpan using TimeOfDay
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Rest of the class remains unchanged
}
