using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class s9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Review",
                value: " ");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Review",
                value: " ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Review",
                value: "Not Good");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Review",
                value: "Good");
        }
    }
}
