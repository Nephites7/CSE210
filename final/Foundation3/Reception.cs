class ReceptionEvent : Event
{
    private string rsvpEmail;

    public ReceptionEvent(string name, string description, DateTime date, DateTime time, EventAddress address, string rsvpEmail)
        : base(name, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}
