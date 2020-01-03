using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HotelPrices",
                columns: new[] { "HotelPriceId", "ClientType", "DateType", "HotelId", "Price" },
                values: new object[,]
                {
                    { 3, "Regular", "Weekend", 1, 90.00m },
                    { 4, "Reward", "Weekend", 1, 80.00m },
                    { 5, "Regular", "Week", 2, 160.00m },
                    { 6, "Reward", "Week", 2, 110.00m },
                    { 7, "Regular", "Weekend", 2, 60.00m },
                    { 8, "Reward", "Weekend", 2, 50.00m },
                    { 9, "Regular", "Week", 3, 220.00m },
                    { 10, "Reward", "Week", 3, 100.00m },
                    { 11, "Regular", "Weekend", 3, 150.00m },
                    { 12, "Reward", "Weekend", 3, 40.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_HotelId",
                table: "Reservation",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotelPrices",
                keyColumn: "HotelPriceId",
                keyValue: 12);
        }
    }
}
