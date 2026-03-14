
namespace BookingSystem.Domain.Entities
{
    public class Event
    {
        public Guid Id { get; set; }

        public Guid PropertyId { get; set; }
        public Guid BookableUnited { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime StartUtc { get; set; }
        public DateTime EndUtc { get; set; }
    }
}
