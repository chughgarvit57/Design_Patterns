namespace DesignPatterns
{
    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public Address EmployeeAddress { get; set; }

        public Employee(string name, string role, string city)
        {
            Name = name;
            Role = role;
            EmployeeAddress = new Address(city);
        }
        // Shallow Copy 
        public object Clone()
        {
            return MemberwiseClone();
        }
        // Deep Copy
        public object DeepClone()
        {
            return new Employee(Name, Role, EmployeeAddress.City);
        }
        public void Display()
        {
            Console.WriteLine($"Employee: {Name}, Role: {Role}, City: {EmployeeAddress.City}");
        }
    }
}
