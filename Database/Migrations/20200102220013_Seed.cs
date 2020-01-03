using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CurrentRating", "Name" },
                values: new object[] { 1, 3m, "Lakewood" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CurrentRating", "Name" },
                values: new object[] { 2, 4m, "Bridgewood" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CurrentRating", "Name" },
                values: new object[] { 3, 5m, "Ridgewood" });

            migrationBuilder.InsertData(
                table: "HotelPrices",
                columns: new[] { "HotelPriceId", "ClientType", "DateType", "HotelId", "Price" },
                values: new object[] { 1, "Regular", "Week", 1, 110.00m });

            migrationBuilder.InsertData(
                table: "HotelPrices",
                columns: new[] { "HotelPriceId", "ClientType", "DateType", "HotelId", "Price" },
                values: new object[] { 2, "Reward", "Week", 1, 80.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1);
        }
    }
}
