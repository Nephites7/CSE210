class OutdoorGatheringEvent : Event
{
    private string weatherCondition;

    public OutdoorGatheringEvent(string name, string description, DateTime date, DateTime time, EventAddress address, string weather)
        : base(name, description, date, time.TimeOfDay, address) // Convert DateTime to TimeSpan using TimeOfDay
    {
        weatherCondition = weather;
    }

    // Rest of the class remains unchanged
}
