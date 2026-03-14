using System;
using System.Collections.Generic;
using System.Text;

namespace BookingSystem.Domain.Entities
{
    public class SeatSection
    {
        public Guid Id { get; set; }

        public Guid BookableUnited { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
