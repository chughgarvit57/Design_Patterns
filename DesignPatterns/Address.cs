namespace DesignPatterns
{
    public class Address
    {
        public string City { get; set; }
        public Address(string city)
        {
            City = city;
        }
        public Address DeepCopy()
        {
            return new Address(City);
        }
    }
}
