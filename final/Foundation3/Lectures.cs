
    public class Lecture : Event
    {
        public string Speaker { get; }
        public int Capacity { get; }

        public Lecture(string title, string description, DateTime eventDate, Address eventAddress, string speaker, int capacity)
            : base(title, description, eventDate, eventAddress)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }
    }
 