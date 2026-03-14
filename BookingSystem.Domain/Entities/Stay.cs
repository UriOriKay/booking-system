namespace BookingSystem.Domain.Entities;

public class Stay
{
    public Guid ID { get; set; }

    public Guid CustomerID { get; set; }
    public Guid PropertyId { get; set; }
    public Guid BookableUnitId { get; set; }

    public DateTime CheckInUtc { get; set; }
    public DateTime CheckOutUtc { get; set; }
}
