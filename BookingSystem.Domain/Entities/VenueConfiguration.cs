namespace BookingSystem.Domain.Entities;


public class VenueConfiguration
{
    public Guid Id { get; set; }
    public Guid BookableUnitId { get; set; }

    public string Name { get; set; } = string.Empty;
    public int MaxCapacity {  get; set; }

    public int SetupDurationHours { get; set; }
    public int TeardownDurationHours { get; set; }
}
