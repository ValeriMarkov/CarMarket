using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CarMarket.Migrations
{
    public partial class CarMarket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(nullable: true),
                    Brand = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Engine = table.Column<double>(nullable: false),
                    HorsePower = table.Column<int>(nullable: false),
                    ManufactureDate = table.Column<DateTime>(nullable: true),
                    TotalMileage = table.Column<int>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    Features = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
