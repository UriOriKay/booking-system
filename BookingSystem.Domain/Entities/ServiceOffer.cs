using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities
{
    public class ServiceOffer : BaseEntity
    {
        public Guid PropertyID { get; set; }

        public string Name { get; set; } = string.Empty;
        public ServiceOfferType Type { get; set; }

        public int MaxCapacityPerSlot { get; set; }
        public int DefaultDurationMinutes { get; set; }

        public Property Property { get; set; } = null!;
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
