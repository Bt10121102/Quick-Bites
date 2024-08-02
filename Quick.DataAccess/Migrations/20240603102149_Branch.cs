using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quick.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Branch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SpecialOffers",
                keyColumn: "SpecialOfferId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SpecialOffers",
                keyColumn: "SpecialOfferId",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 City Center", "Jad ", "Downtown", "71-456-7890" },
                    { 2, "456 Up Street", "Jane Smith", "Uptown", "71-654-3210" },
                    { 3, "789 Sub Lane", "Alice Johnson", "Suburban", "71-555-5555" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.InsertData(
                table: "SpecialOffers",
                columns: new[] { "SpecialOfferId", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "Get up to 10% off when buying any 3 sandwishes", new DateTime(2024, 7, 3, 3, 24, 17, 977, DateTimeKind.Local).AddTicks(7787), "Summer Sale", new DateTime(2024, 6, 3, 3, 24, 17, 977, DateTimeKind.Local).AddTicks(7732) },
                    { 2, "buy 2 sandwishes get beverage free ", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "special offer", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
