using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarMarket.Migrations
{
    public partial class CarMarket1 : Migration
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
                    Transmission = table.Column<int>(nullable: false),
                    Fuel = table.Column<int>(nullable: false),
                    HorsePower = table.Column<int>(nullable: false),
                    ManufactureDate = table.Column<DateTime>(nullable: true),
                    TotalMileage = table.Column<int>(nullable: false),
                    Doors = table.Column<int>(nullable: false),
                    SteeringWheel = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureURL = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Manager = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
