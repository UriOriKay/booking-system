
namespace BookingSystem.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreateAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
        public byte[]? RowVersion { get; set; }
    }
}
