using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database
{
    public class TestContext : DbContext
    {

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<HotelPrice> HotelPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='TestProject';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 1,
                    Name = "Lakewood",
                    CurrentRating = 3
                },
                new Hotel
                {
                    HotelId = 2,
                    Name = "Bridgewood",
                    CurrentRating = 4
                },
                new Hotel
                {
                    HotelId = 3,
                    Name = "Ridgewood",
                    CurrentRating = 5
                });

            modelBuilder.Entity<HotelPrice>().HasData(
                new HotelPrice
                {
                    HotelPriceId = 1,
                    HotelId = 1,
                    ClientType = "Regular",
                    DateType = "Week",
                    Price = 110.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 2,
                    HotelId = 1,
                    ClientType = "Reward",
                    DateType = "Week",
                    Price = 80.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 3,
                    HotelId = 1,
                    ClientType = "Regular",
                    DateType = "Weekend",
                    Price = 90.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 4,
                    HotelId = 1,
                    ClientType = "Reward",
                    DateType = "Weekend",
                    Price = 80.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 5,
                    HotelId = 2,
                    ClientType = "Regular",
                    DateType = "Week",
                    Price = 160.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 6,
                    HotelId = 2,
                    ClientType = "Reward",
                    DateType = "Week",
                    Price = 110.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 7,
                    HotelId = 2,
                    ClientType = "Regular",
                    DateType = "Weekend",
                    Price = 60.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 8,
                    HotelId = 2,
                    ClientType = "Reward",
                    DateType = "Weekend",
                    Price = 50.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 9,
                    HotelId = 3,
                    ClientType = "Regular",
                    DateType = "Week",
                    Price = 220.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 10,
                    HotelId = 3,
                    ClientType = "Reward",
                    DateType = "Week",
                    Price = 100.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 11,
                    HotelId = 3,
                    ClientType = "Regular",
                    DateType = "Weekend",
                    Price = 150.00M
                },
                new HotelPrice
                {
                    HotelPriceId = 12,
                    HotelId = 3,
                    ClientType = "Reward",
                    DateType = "Weekend",
                    Price = 40.00M
                });
        }
    }
}
