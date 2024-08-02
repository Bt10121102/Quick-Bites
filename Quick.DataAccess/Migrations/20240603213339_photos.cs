using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quick.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class photos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ImageUrl",
                value: "images\\product\\025cd8e9-fd3e-4fad-b931-180f8335b16f.PNG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ImageUrl",
                value: "");
        }
    }
}
