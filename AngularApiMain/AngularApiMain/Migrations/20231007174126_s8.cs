using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class s8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "Rating", "Review" },
                values: new object[] { 4.0, "Not Good" });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "Rating", "Review" },
                values: new object[] { 4.0, "Good" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "orders");
        }
    }
}
