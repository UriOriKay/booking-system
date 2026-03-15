namespace BookingSystem.Domain.Entities;


public class VenueConfiguration : BaseEntity
{
    public Guid BookableUnitId { get; set; }

    public string Name { get; set; } = string.Empty;
    public int MaxCapacity {  get; set; }

    public int SetupDurationHours { get; set; }
    public int TeardownDurationHours { get; set; }

    public BookableUnit BookableUnit { get; set; } = null!;
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
