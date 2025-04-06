
    public class Address
    {
        public string Street { get; }
        public string City { get; }
        public string Country { get; }

        public Address(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {Country}";
        }
    }
