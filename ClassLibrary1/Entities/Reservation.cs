using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public int HotelId { get; set; }

        public DateTime Date { get; set; }

        public Hotel Hotel { get; set; }
    }
}
