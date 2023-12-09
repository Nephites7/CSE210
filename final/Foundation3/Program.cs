class EventManager
{
    static void Main()
    {
        EventAddress eventAddress = new EventAddress("123 Main St", "Cityville", "CA", "USA");

        Event standardEvent = new Event("Generic Event", "A generic event description.", DateTime.Now.Date, DateTime.Now.TimeOfDay, eventAddress);
        Console.WriteLine("Basic Details:\n" + standardEvent.GetBasicDetails());
        Console.WriteLine("\nFull Details:\n" + standardEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + standardEvent.GetShortDescription());

        Console.WriteLine("\n---------------------------\n");

        LectureEvent lectureEvent = new LectureEvent("Tech Talk", "An informative tech lecture.", DateTime.Now.Date, DateTime.Now
, eventAddress, "John Doe", 50);
        Console.WriteLine("Basic Details:\n" + lectureEvent.GetBasicDetails());
        Console.WriteLine("\nFull Details:\n" + lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + lectureEvent.GetShortDescription());

        Console.WriteLine("\n---------------------------\n");

        ReceptionEvent receptionEvent = new ReceptionEvent("Networking Mixer", "A casual networking event.", DateTime.Now.Date, DateTime.Now
, eventAddress, "rsvp@example.com");
        Console.WriteLine("Basic Details:\n" + receptionEvent.GetBasicDetails());
        Console.WriteLine("\nFull Details:\n" + receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + receptionEvent.GetShortDescription());

        Console.WriteLine("\n---------------------------\n");

        OutdoorGatheringEvent outdoorEvent = new OutdoorGatheringEvent("Picnic in the Park", "Enjoy a day outdoors.", DateTime.Now.Date, DateTime.Now
, eventAddress, "Sunny");
        Console.WriteLine("Basic Details:\n" + outdoorEvent.GetBasicDetails());
        Console.WriteLine("\nFull Details:\n" + outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + outdoorEvent.GetShortDescription());
    }
}
