using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities
{
    public class ServiceOffer
    {
        public Guid Id { get; set; }
        public Guid PropertyID { get; set; }

        public string Name { get; set; } = string.Empty;
        public ServiceOfferType Type { get; set; }

        public int MaxCapacityPerSlot { get; set; }
        public int DefaultDurationMinutes { get; set; }
    }
}
