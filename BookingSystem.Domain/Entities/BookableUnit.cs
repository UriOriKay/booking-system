using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities;

public class BookableUnit : BaseEntity
{
    public Guid PropertyId { get; set; }

    public string Name { get; set; } = string.Empty;
    public BookableUnitType Type { get; set; }
    public int Capacity { get; set; }

    public Property Property { get; set; } = null!;

    public ICollection<VenueConfiguration> VenueConfigurations { get; set; } = new List<VenueConfiguration>();
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public ICollection<Stay> Stays { get; set; } = new List<Stay>();
}
