namespace BookingSystem.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Guid CompanyId { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Company Company { get; set; } = null!;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Stay> Stays { get; set; } = new List<Stay>();
    }
}
