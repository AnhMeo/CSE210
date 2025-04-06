using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Create an address
            Address eventAddress = new Address("123 Event St.", "Ho Chi Minh City", "Vietnam");

            // Create events
            Lecture lectureEvent = new Lecture("Tech Innovations Lecture", "A lecture on the latest tech trends.", new DateTime(2025, 5, 10, 10, 0, 0), eventAddress, "Dr. John Doe", 100);
            Reception receptionEvent = new Reception("Annual Gala", "A reception for our loyal customers.", new DateTime(2025, 6, 15, 19, 0, 0), eventAddress, "rsvp@company.com");
            OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "An outdoor picnic with games and food.", new DateTime(2025, 7, 20, 11, 0, 0), eventAddress, "Sunny with a chance of rain.");

            // Generate and print marketing messages for each event
            Console.WriteLine(lectureEvent.StandardDetails());
            Console.WriteLine("-----------------------");
            Console.WriteLine(lectureEvent.FullDetails());
            Console.WriteLine("-----------------------");
            Console.WriteLine(lectureEvent.ShortDescription());

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(receptionEvent.StandardDetails());
            Console.WriteLine("-----------------------");
            Console.WriteLine(receptionEvent.FullDetails());
            Console.WriteLine("-----------------------");
            Console.WriteLine(receptionEvent.ShortDescription());

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(outdoorEvent.StandardDetails());
            Console.WriteLine("-----------------------");
            Console.WriteLine(outdoorEvent.FullDetails());
            Console.WriteLine("-----------------------");
            Console.WriteLine(outdoorEvent.ShortDescription());
        }
    }
