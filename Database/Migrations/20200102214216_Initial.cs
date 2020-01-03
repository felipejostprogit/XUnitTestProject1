using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CurrentRating = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelPrices",
                columns: table => new
                {
                    HotelPriceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(nullable: false),
                    ClientType = table.Column<string>(nullable: true),
                    DateType = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelPrices", x => x.HotelPriceId);
                    table.ForeignKey(
                        name: "FK_HotelPrices_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelPrices_HotelId",
                table: "HotelPrices",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelPrices");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
