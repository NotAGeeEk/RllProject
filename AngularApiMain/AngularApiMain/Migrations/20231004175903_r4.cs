using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class r4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "fooditems",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 225);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 250);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 270);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 120);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 70);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 50);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 100);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 300);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 70);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 130);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 80);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 150);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 110);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 150);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 170);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 190);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 135);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 146);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 120);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 140);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 280);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 290);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 310);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 290);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 285);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 350);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 410);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 140);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 180);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 245);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "fooditems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 225m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 250m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 270m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 120m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 70m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 300m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 70m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 110m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 170m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 190m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 135m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 146m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 120m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 280m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 290m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 310m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 290m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 285m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 350m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 410m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 180m);

            migrationBuilder.UpdateData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 245m);
        }
    }
}
