using System;

class Event
{
    private string eventName;
    private string eventDescription;
    private DateTime eventDate;
    private TimeSpan eventTime; // Change DateTime to TimeSpan
    private EventAddress eventAddress;

    public Event(string name, string description, DateTime date, TimeSpan time, EventAddress address)
    {
        eventName = name;
        eventDescription = description;
        eventDate = date;
        eventTime = time;
        eventAddress = address;
    }

    public string GetBasicDetails()
    {
        return $"Event: {eventName}\nDescription: {eventDescription}\nDate: {eventDate.ToShortDateString()}\nTime: {eventTime.ToString(@"hh\:mm")}\nAddress: {eventAddress.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetBasicDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: Event\nTitle: {eventName}\nDate: {eventDate.ToShortDateString()}";
    }
}
