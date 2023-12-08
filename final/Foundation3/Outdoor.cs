class OutdoorGatheringEvent : Event
{
    private string weatherCondition;

    public OutdoorGatheringEvent(string name, string description, DateTime date, DateTime time, EventAddress address, string weather)
        : base(name, description, date, time, address)
    {
        weatherCondition = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weatherCondition}";
    }
}
