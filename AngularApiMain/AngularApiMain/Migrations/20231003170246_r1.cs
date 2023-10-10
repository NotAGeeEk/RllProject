using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class r1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "fooditems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fooditems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fooditems_restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Since 1978, Eat Sweet and Talk Sweetly.", "https://i.pinimg.com/originals/7d/74/19/7d7419496c7c143aadfbcffcfd6c2812.png", "Radhika", 4.5, 1 },
                    { 2, "Be A King Like Burger King.", "https://www.shutterstock.com/shutterstock/photos/2129642369/display_1500/stock-photo-amsterdam-netherlands-feb-burger-set-from-burger-king-restaurant-burger-king-s-2129642369.jpg", "Burger King", 4.0, 2 },
                    { 3, "It's All About Domino's Pizza.....", "https://smartcanucks.ca/wp-content/uploads/2015/12/dominos-pizza.jpg", "Dominos", 4.2000000000000002, 3 }
                });

            migrationBuilder.InsertData(
                table: "fooditems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Creamy lentils cooked with spices.", "dal_makhni.jpg", "Dal Makhni", 4.5, 1 },
                    { 2, "Paneer cooked in a rich tomato-based gravy.", "shahi_paneer.jpg", "Shahi Paneer", 4.4000000000000004, 1 },
                    { 3, "Creamy paneer dish cooked in a handi.", "handi_panner.jpg", "Handi Panner", 4.5999999999999996, 1 },
                    { 4, "Fried bread with spicy chickpea curry.", "chole_bhature.jpg", "Chole Bhature", 4.2000000000000002, 1 },
                    { 5, "Soft and buttery Indian flatbread.", "butter_naan.jpg", "Butter Naan", 4.2999999999999998, 1 },
                    { 6, "Traditional Indian flatbread made with gram flour.", "missi_roti.jpg", "Missi Roti", 4.0, 1 },
                    { 7, "Dessert made from paneer in sweet milk.", "rasmalai.jpg", "Rasmalai", 4.7000000000000002, 1 },
                    { 8, "Delicious cake for dessert.", "cake.jpg", "Cake", 4.2000000000000002, 1 },
                    { 9, "Refreshing cola drink.", "coke.jpg", "Coke", 4.0, 1 },
                    { 10, "Creamy and sweet ice cream.", "ice_cream.jpg", "IceCream", 4.5, 1 },
                    { 11, "Vegetarian burger with fresh veggies.", "veg_burger.jpg", "Veg Burger", 4.2000000000000002, 2 },
                    { 12, "Crispy and crunchy burger with a special sauce.", "crispy_burger.jpg", "Crispy Burger", 4.0999999999999996, 2 },
                    { 13, "Burger with cheesy goodness.", "chesse_burger.jpg", "Chesse Burger", 4.2999999999999998, 2 },
                    { 14, "Double the cheese for double the delight.", "double_chesse_burger.jpg", "Double Chesse Burger", 4.4000000000000004, 2 },
                    { 15, "Burger with delicious chicken patty.", "chicken_burger.jpg", "Chicken Burger", 4.0, 2 },
                    { 16, "Burger with a spicy kick of pepper.", "pepper_burger.jpg", "Pepper Burger", 4.0999999999999996, 2 },
                    { 17, "Burger with corn filling.", "corn_burger.jpg", "Corn Burger", 4.2000000000000002, 2 },
                    { 18, "Burger with roasted ingredients.", "roasted_burger.jpg", "Roasted Burger", 4.2999999999999998, 2 },
                    { 19, "Refreshing cola drink.", "coke.jpg", "Coke", 4.0, 2 },
                    { 20, "Delicious brownie cake for dessert.", "brownie_cake.jpg", "Brownie Cake", 4.5, 2 },
                    { 21, "Pizza with sweet corn toppings.", "sweetcorn_pizza.jpg", "SweetCorn Pizza", 4.5999999999999996, 3 },
                    { 22, "Pizza with capsicum and cheese.", "capsicum_pizza.jpg", "Capsicum Pizza", 4.5, 3 },
                    { 23, "Pizza with mozzarella cheese and veggies.", "mozeralla_cheese_pizza.jpg", "Mozeralla cheese pizza with veggies", 4.4000000000000004, 3 },
                    { 24, "Pizza with double cheese burst.", "double_cheeseburst_pizza.jpg", "Double CheeseBurst Pizza", 4.5999999999999996, 3 },
                    { 25, "Pizza with paneer toppings.", "paneer_pizza.jpg", "Paneer Pizza", 4.2999999999999998, 3 },
                    { 26, "Classic Margherita pizza with tomatoes and basil.", "margherita_pizza.jpg", "Margherita pizza", 4.2000000000000002, 3 },
                    { 27, "Pizza with cheesy chicken and pasta toppings.", "cheesy_chicken_pasta_pizza.jpg", "Cheesy chicken pasta pizza", 4.5, 3 },
                    { 28, "Refreshing cola drink.", "coke.jpg", "Coke", 4.0, 3 },
                    { 29, "Molten lava cake for dessert.", "lava_cake.jpg", "Lava Cake", 4.7000000000000002, 3 },
                    { 30, "Creamy and sweet ice cream.", "ice_cream.jpg", "IceCream", 4.4000000000000004, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_fooditems_RestaurantId",
                table: "fooditems",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fooditems");

            migrationBuilder.DropTable(
                name: "restaurants");
        }
    }
}
