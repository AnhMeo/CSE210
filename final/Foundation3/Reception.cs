    public class Reception : Event
    {
        public string RsvpEmail { get; }

        public Reception(string title, string description, DateTime eventDate, Address eventAddress, string rsvpEmail)
            : base(title, description, eventDate, eventAddress)
        {
            RsvpEmail = rsvpEmail;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nEvent Type: Reception\nRSVP Email: {RsvpEmail}";
        }
    }
