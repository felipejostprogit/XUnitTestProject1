using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Hotel
    {
        public int HotelId { get; set; }

        public string Name { get; set; }

        public decimal CurrentRating { get; set; }

        public ICollection<HotelPrice> HotelPrices { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
