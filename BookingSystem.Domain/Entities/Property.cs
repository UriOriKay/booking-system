using BookingSystem.Domain.Enums;

namespace BookingSystem.Domain.Entities
{
    public class Property : BaseEntity
    {
        public Guid CompanyId { get; set; }

        public string Name { get; set; } = string.Empty;
        public PropertyType Type { get; set; }
        public string Address { get; set; } = string.Empty;

        public Company Company { get; set; } = null!;

        public ICollection<BookableUnit> BookableUnits { get; set; } = new List<BookableUnit>();
        public ICollection<ServiceOffer> ServiceOffers { get; set; } = new List<ServiceOffer>();
        public ICollection<ActivityOffer> ActivityOffers { get; set; } = new List<ActivityOffer>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
