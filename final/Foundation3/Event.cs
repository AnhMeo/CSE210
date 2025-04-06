using System;

    public abstract class Event
    {
        public string Title { get; }
        public string Description { get; }
        public DateTime EventDate { get; }
        public Address EventAddress { get; }

        protected Event(string title, string description, DateTime eventDate, Address eventAddress)
        {
            Title = title;
            Description = description;
            EventDate = eventDate;
            EventAddress = eventAddress;
        }

        public virtual string StandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {EventDate:MMMM dd, yyyy}\nTime: {EventDate:HH:mm}\nAddress: {EventAddress}";
        }

        public abstract string FullDetails();

        public virtual string ShortDescription()
        {
            return $"Type: {GetType().Name}\nTitle: {Title}\nDate: {EventDate:MMMM dd, yyyy}";
        }
    }
