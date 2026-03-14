namespace BookingSystem.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
