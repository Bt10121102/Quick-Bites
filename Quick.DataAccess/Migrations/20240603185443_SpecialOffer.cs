using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quick.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SpecialOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[] { "Backyard Hazmieh", "Hadi Shweiry", "QuickBites", "71-422-501" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 2,
                columns: new[] { "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[] { " City Center", "Jad Sawaya", "QuickBites", "71-456-789" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 3,
                columns: new[] { "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[] { "ABC Verdun", "Ali Sbeity", "QuickBites", "71-654-321" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[] { 4, "Le Mall", "Ilias Zein", "QuickBites", "71-555-555" });

            migrationBuilder.InsertData(
                table: "SpecialOffers",
                columns: new[] { "SpecialOfferId", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "Get 25% off any burger combo with side salad and a drink this holiday season!", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holiday Combo", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Enjoy a 15% discount on all salads this summer!", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Special", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Brunch with us for a 15% discount  from 11 am till 1 pm every monday!", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monday Brunch", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SpecialOffers",
                keyColumn: "SpecialOfferId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SpecialOffers",
                keyColumn: "SpecialOfferId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SpecialOffers",
                keyColumn: "SpecialOfferId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[] { "123 City Center", "Jad ", "Downtown", "71-456-7890" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 2,
                columns: new[] { "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[] { "456 Up Street", "Jane Smith", "Uptown", "71-654-3210" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 3,
                columns: new[] { "Address", "Manager", "Name", "PhoneNumber" },
                values: new object[] { "789 Sub Lane", "Alice Johnson", "Suburban", "71-555-5555" });
        }
    }
}
