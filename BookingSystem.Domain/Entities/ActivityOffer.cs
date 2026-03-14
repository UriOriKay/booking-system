using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities
{
    public class ActivityOffer
    {
        public Guid Id { get; set; }
        public Guid PropertyId { get; set; }

        public string Name { get; set; } = string.Empty;
        public ActivityOfferType Type {  get; set; }

        public int MaxParticipants { get; set; }
        public DateTime StartUtc { get; set; }
        public DateTime EndUtc { get; set; }
    }
}
