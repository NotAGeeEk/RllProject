using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class s1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fooditems_orders_OrderId",
                table: "fooditems");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropIndex(
                name: "IX_fooditems_OrderId",
                table: "fooditems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "fooditems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "fooditems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_orders_restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 13,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 14,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 15,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 16,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 17,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 18,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 19,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 20,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 21,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 22,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 23,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 24,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 25,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 26,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 27,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 28,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 29,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 30,
                column: "OrderId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_fooditems_OrderId",
                table: "fooditems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_RestaurantId",
                table: "orders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_fooditems_orders_OrderId",
                table: "fooditems",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId");
        }
    }
}
