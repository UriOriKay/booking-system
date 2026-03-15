namespace BookingSystem.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<Property> Properties { get; set; } = new List<Property>();
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
