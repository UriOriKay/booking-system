using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities;

public class BookableUnit
{
    public Guid Id { get; set; }
    public Guid PropertyId { get; set; }

    public string Name { get; set; } = string.Empty;
    public BookableUnitType Type { get; set; }

    public int Capacity { get; set; }
}
