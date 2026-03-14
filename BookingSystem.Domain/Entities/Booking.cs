using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities;
internal class Booking
{
    public Gud Id { get; set; }

    public Guid CustomerId { get; set; }
    public Guid PropertyId { get; set; }

    public BookingTargetType targetType { get; set; }

    public Guid? BooakableUnitId { get; set; }
    public Guid? ServiceOfferId { get; set; }
    public Guid? ActivityOfferId { get; set; }
    public Guid? VenueConfiguration {  get; set; }
    public Guid? StayId { get; set; }

    public DateTime StartUtc { get; set; }
    public DateTime EndUtc { get; set; }

    public int PartySize { get; set; }

    public BookingStatus Status { get; set; }
}

