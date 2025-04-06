using System;

class Program
{
    static void Main()
    {
        Address address = new Address("123 Event St", "Ho Chi Minh City", "Ho Chi Minh", "700000");

        Event lecture = new LectureEvent("Tech Talk", "A talk about cybersecurity", new DateTime(2025, 5, 10), new DateTime(2025, 5, 10, 14, 0, 0), address, "John Doe", 100);
        Event reception = new ReceptionEvent("Business Networking", "Networking event for professionals", new DateTime(2025, 5, 12), new DateTime(2025, 5, 12, 18, 0, 0), address, "rsvp@business.com");
        Event outdoorGathering = new OutdoorGatheringEvent("Beach Cleanup", "Join us for a community beach cleanup", new DateTime(2025, 5, 15), new DateTime(2025, 5, 15, 9, 0, 0), address, "Sunny");

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
