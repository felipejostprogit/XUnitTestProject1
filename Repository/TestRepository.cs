using Database;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class TestRepository : ITestRepository, IDisposable
    {
        private readonly TestContext context;

        public TestRepository()
        {
            this.context = new TestContext();
        }

        ~TestRepository()
        {
            this.context.Dispose();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public Hotel FindBestHotel(string clientType, DateTime[] dates)
        {
            var hotels = this.context.Set<Hotel>().Include("HotelPrices").Where(hotel =>
               hotel.HotelPrices.Any(price => price.ClientType == clientType)
               && !hotel.Reservations.Any(reservation => dates.Contains(reservation.Date)));

            var reservationPrices = new List<Tuple<Hotel, decimal>>();

            foreach (var hotel in hotels)
            {
                decimal? reservationPrice = 0.0M;

                foreach (var date in dates)
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        reservationPrice += hotel.HotelPrices.OrderBy(p => p.Price).FirstOrDefault(price => price.DateType == "Weekend" && price.ClientType == clientType)?.Price;
                    }
                    else {
                        reservationPrice += hotel.HotelPrices.OrderBy(p => p.Price).FirstOrDefault(price => price.DateType == "Week" && price.ClientType == clientType)?.Price;
                    }
                }

                if(reservationPrice.HasValue)
                    reservationPrices.Add(new Tuple<Hotel, decimal>(hotel, reservationPrice.Value));
            }

            return reservationPrices.OrderBy(price => price.Item2).ThenByDescending(price => price.Item1.CurrentRating).FirstOrDefault()?.Item1;
        }
    }
}
