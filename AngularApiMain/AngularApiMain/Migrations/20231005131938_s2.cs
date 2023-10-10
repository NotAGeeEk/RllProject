using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class s2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderId);
                });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "OrderId", "Food", "OrderTime", "RestaurantId", "UserId" },
                values: new object[,]
                {
                    { 1, "[{\"name\":\"burger\",\"price\":23},{\"name\":\"pizza\",\"price\":32}]", "Thu Oct 05 2023 00:06:25 GMT+0530 (India Standard Time)", 1, 1 },
                    { 2, "[{\"name\":\"pasta\",\"price\":22},{\"name\":\"tacos\",\"price\":12}]", "Fri Oct 06 2023 01:07:26 GMT+0530 (India Standard Time)", 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
