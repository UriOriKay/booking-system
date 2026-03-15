using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities;
public class Booking : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Guid PropertyId { get; set; }

    public BookingTargetType targetType { get; set; }

    public Guid? BooakableUnitId { get; set; }
    public Guid? ServiceOfferId { get; set; }
    public Guid? ActivityOfferId { get; set; }
    public Guid? VenueConfigurationId {  get; set; }
    public Guid? StayId { get; set; }

    public DateTime StartUtc { get; set; }
    public DateTime EndUtc { get; set; }

    public int PartySize { get; set; }

    public BookingStatus Status { get; set; }

    public Customer Customer { get; set; } = null!;
    public Property Property { get; set; } = null!;
    public BookableUnit? BookableUnit { get; set; }
    public ServiceOffer? ServiceOffer { get; set; }
    public ActivityOffer? ActivityOffer { get; set; }
    public VenueConfiguration? VenueConfiguration { get; set; }
    public Stay? Stay { get; set; }
    public bool HasValidPeriod()
    {
        return EndUtc > StartUtc;
    }

    public bool HasInvalidPartySize()
    {
        return PartySize > 0;
    }
}


