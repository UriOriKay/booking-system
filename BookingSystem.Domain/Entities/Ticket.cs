namespace BookingSystem.Domain.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public Guid EventId { get; set; }
        public Guid SeatId { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime PurchasedUtc { get; set; }
    }
}
