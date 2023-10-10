using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class s5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Rating", "RestaurantId" },
                values: new object[] { 4, "Where Shakes Come to Life", "https://b.zmtcdn.com/data/pictures/7/20569307/960684662f5846e1a6d91a3255e218a9_featured_v2.jpg", "ShakesEra", 4.2999999999999998, 4 });

            migrationBuilder.InsertData(
                table: "fooditems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 31, "Velvety vanilla ice cream blended to perfection.", "https://img.freepik.com/free-photo/front-view-delicious-milkshake-with-yellow-background_23-2148296082.jpg?w=360&t=st=1696658844~exp=1696659444~hmac=29a27f2de60eb1158ff77250ed4a41016f010b41e916f67fe3c05fb651dd7556", "Classic Vanilla Bliss Shake", 200, 4.5, 4 },
                    { 32, "A heavenly blend of premium chocolate ice cream.", "https://img.freepik.com/free-photo/creamy-vanilla-milky-shake-with-chocolate-sauce-white-saucer_114579-10109.jpg?w=900&t=st=1696659043~exp=1696659643~hmac=e10799cbf337bf2812c5bf8881d9d3eadd1584770b6076db5343a6df612ae566", "Decadent Chocolate Avalanche Shake", 250, 4.2000000000000002, 4 },
                    { 33, "Made with ripe strawberries.", "https://img.freepik.com/premium-photo/glass-fresh-strawberry-smoothie-juice-with-cream-strawberry_641698-190.jpg?size=626&ext=jpg&ga=GA1.1.698317621.1696062515&semt=ais", "Strawberry Fields Forever Shake", 310, 4.4000000000000004, 4 },
                    { 34, " Ice cream meets crunchy toffee bits, swirled with caramel sauce.", "https://media.istockphoto.com/id/673742908/photo/iced-caramel-latte-coffee-in-a-tall-glass.webp?b=1&s=170667a&w=0&k=20&c=KjaUNWbOesPu-ZDwk6R8xfmACAZ5lHS42vQJpIvtLRA=", "Caramel Crunch Delight Shake", 280, 4.0999999999999996, 4 },
                    { 35, "Mint chocolate chip ice cream Melody", "https://media.istockphoto.com/id/1407551345/photo/homemade-green-chocolate-chip-mint-milkshake.jpg?s=612x612&w=0&k=20&c=ah27-9_xwyR_oTXAMHdQlKHg-Q31ARZggwUY2ioyhd8=", "Minty Fresh Chocolate Chip Shake", 270, 4.0, 4 },
                    { 36, " Creamy peanut butter and chocolate ice cream .", "https://media.istockphoto.com/id/522334972/photo/peanut-butter-banana-oat-smoothie-on-rustic-wood-with-scattered-ingredients.jpg?s=612x612&w=0&k=20&c=F_0O7J_x36jHY7-eVMYoOdjEMlnahMTH7_kDCXO6XUA=", "Peanut Butter Paradise Shake", 290, 3.8999999999999999, 4 },
                    { 37, "A velvety blend of cookies ", "https://media.istockphoto.com/id/1308045723/photo/cold-coffee-frappuccino.jpg?s=612x612&w=0&k=20&c=drB225PkXKnjRzym-06I3rQs2dawXXb2mxsdbkj9aK0=", "Cookies 'n' Cream Dream Shake", 335, 4.7000000000000002, 4 },
                    { 38, " a heavenly blend of ripe bananas", "https://media.istockphoto.com/id/1298479104/photo/chocolate-smoothie-with-choco-syrup-and-branch-of-bananas.jpg?s=612x612&w=0&k=20&c=IcFzt-i-MUYJuSpLBBUlMCi1jdBkjqxc8E0F_0fHjho=", "Banana Nutella Fusion Shake", 246, 4.9000000000000004, 4 },
                    { 39, "Fresh mangoes blended with creamy coconut ice cream", "https://media.istockphoto.com/id/537632144/photo/fresh-tropical-fruit-smoothie-mango-juice.jpg?s=612x612&w=0&k=20&c=HcQ1SyHOzrwe-0Aj5_pkzQPXIktjc4B4tQ5OGJPCAAM=", "Tropical Paradise Mango Shake", 320, 4.7999999999999998, 4 },
                    { 40, "the Espresso Brownie Buzz Shake is a must-try. Cold-brewed espresso, brownie chunks, and coffee", "https://media.istockphoto.com/id/671860998/photo/iced-chocolate-on-glass-table-top.jpg?s=612x612&w=0&k=20&c=WMrLqNNR3IAZQVlzWTB8Df1akxorcB9a0Wj1Q5BtT3M=", "Espresso Brownie Buzz Shake", 240, 4.5, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
