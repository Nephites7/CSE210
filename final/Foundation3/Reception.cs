class ReceptionEvent : Event
{
    private string emailForRSVP;

    public ReceptionEvent(string name, string description, DateTime date, DateTime time, EventAddress address, string email)
        : base(name, description, date, time.TimeOfDay, address) // Convert DateTime to TimeSpan using TimeOfDay
    {
        emailForRSVP = email;
    }

    // Rest of the class remains unchanged
}
