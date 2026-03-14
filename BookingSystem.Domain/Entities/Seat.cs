namespace BookingSystem.Domain.Entities
{
    public class Seat
    {
        public Guid Id { get; set; }

        public Guid SeatSectionId { get; set; }

        public string Row {  get; set; } = string.Empty;

        public int Number {  get; set; }
    }
}
