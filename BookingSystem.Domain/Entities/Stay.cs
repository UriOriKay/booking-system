namespace BookingSystem.Domain.Entities;

public class Stay : BaseEntity
{
    public Guid CustomerID { get; set; }
    public Guid PropertyId { get; set; }
    public Guid BookableUnitId { get; set; }

    public DateTime CheckInUtc { get; set; }
    public DateTime CheckOutUtc { get; set; }

    public Customer Customer { get; set; } = null!;
    public Property Property { get; set; } = null!;
    public BookableUnit BookableUnit { get; set; } = null!;

    public bool HasValidPeriod()
    {
        return CheckOutUtc > CheckInUtc;
    }
}
