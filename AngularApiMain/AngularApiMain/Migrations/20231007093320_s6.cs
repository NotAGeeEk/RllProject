using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AngularApiMain.Migrations
{
    /// <inheritdoc />
    public partial class s6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "fooditems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Rating", "RestaurantId" },
                values: new object[] { 65, "This dish is made of Rava/Semolina with Dal and Other spices.", "https://thumbs.dreamstime.com/b/upma-made-samolina-rava-upma-most-famous-south-indian-breakfast-item-which-beautifully-arranged-plate-banana-216111370.jpg", "Upma Kitchadi", 90, 3.7999999999999998, 2 });

            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 5, "Discover a World of Ice Cream", "https://content.jdmagicbox.com/comp/kolkata/x4/033pxx33.xx33.210811101413.v9x4/catalogue/baskin-robbins-batanagar-kolkata-ice-cream-parlours-d2mjjj2dz9.jpg", "Baskin Ice Cream", 4.4000000000000004, 5 },
                    { 6, "The Home of Authentic Biryani", "https://images.unsplash.com/photo-1563379091339-03b21ab4a4f8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8YmlyeWFuaXxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", "Biryani Junction", 4.0999999999999996, 6 },
                    { 7, "Experience South Indian Delights", "https://images.unsplash.com/photo-1668236543090-82eba5ee5976?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGRvc2F8ZW58MHx8MHx8fDA%3D&w=1000&q=80", "South Pride", 4.5999999999999996, 7 }
                });

            migrationBuilder.InsertData(
                table: "fooditems",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 41, " A timeless favorite with a creamy, velvety texture and the pure essence of Madagascar vanilla beans..", "https://media.istockphoto.com/id/659314530/photo/sweet-vanilla-ice-cream.jpg?s=612x612&w=0&k=20&c=y6LzVSTb8lP4suQutOEgBfxtrdiBgVLfBZMb4-00qMU=", "Classic Vanilla Bliss", 220, 4.0999999999999996, 5 },
                    { 42, "Rich, indulgent chocolate ice cream loaded with chunks of gooey fudge brownies for the ultimate chocolate lover's delight..", "https://media.istockphoto.com/id/134203159/photo/brownie-cake.jpg?s=612x612&w=0&k=20&c=8adTLMUNTiZ3fhU9vidOv3M6mI72yPf5Gn9XQ1cHJcs=", "Decadent Chocolate Fudge Brownie", 240, 3.8999999999999999, 5 },
                    { 43, "Sweet and refreshing strawberry ice cream made from ripe, hand-picked strawberries, perfect for a taste of summer.", "https://media.istockphoto.com/id/470712118/photo/scoops-of-strawberry-ice-cream-in-a-dish-with-mint-garnish.jpg?s=612x612&w=0&k=20&c=DmrzpbV-e8tkLHuptylMJ3A4ljcBEszEOqA4vjFVwhM=", "Strawberry Fields Forever", 200, 4.7999999999999998, 5 },
                    { 44, "Cool and refreshing mint ice cream generously studded with dark chocolate chips, providing a delightful contrast of flavors.", "https://media.istockphoto.com/id/1332759408/photo/mint-ice-cream-with-chocolate-chips.jpg?s=612x612&w=0&k=20&c=zH6oJaXiliHcqMm7LGQ--qzZ6hDgDYfwuYMr3bgcLFw=", "Mint Chocolate Chip Delight", 280, 4.4000000000000004, 5 },
                    { 45, "Creamy vanilla ice cream blended with chunks of chocolate sandwich cookies for a satisfying crunch in every bite.", "https://media.istockphoto.com/id/154245754/photo/real-gourmet-ice-cream.jpg?s=612x612&w=0&k=20&c=QN9crvD_if0d3brbqjlCeEiBK247WYLxwkp9si6txXE=", "Cookies 'n Cream Dream", 290, 4.5, 5 },
                    { 46, "Nutty pistachio ice cream blended with toasted almonds, offering a unique and delightful flavor profile.", "https://media.istockphoto.com/id/1304761771/photo/pistachio-ice-cream-with-pistachio-nuts-glass-ice-cream-bowl-on-a-dark-background-horizontal.jpg?s=612x612&w=0&k=20&c=O8uj7UYEHjbOqNqmcRscRt29NPAJrzAlU-sJx7aVpEQ=", "Pistachio Almond Euphoria", 280, 4.2999999999999998, 5 },
                    { 47, "A refreshing dairy-free option with a medley of tropical fruits like pineapple, mango, and passion fruit, creating a burst of exotic flavors.", "https://media.istockphoto.com/id/1051348322/photo/ice.jpg?s=1024x1024&w=is&k=20&c=Ua32dlxMO5MQ7V82kPcJ5KTHMVaiE2ZhxDA_fFZFcMs=", "Tropical Paradise Sorbet", 250, 4.0, 5 },
                    { 48, "Creamy coffee ice cream infused with bits of buttery toffee and a hint of espresso, perfect for coffee enthusiasts.", "https://media.istockphoto.com/id/523693554/photo/vanilla-ice-cream-with-nuts-chocolate-and-caramel.jpg?s=612x612&w=0&k=20&c=puKzTWxTrn7jM7lLZMZyhh8NW9hb5hEENzhE1Xbtjyo=", "Coffee Toffee Crunch", 210, 4.5999999999999996, 5 },
                    { 49, "A delightful mix of chocolate ice cream with marshmallows and roasted almonds, providing a satisfying combination of textures and flavors.", "https://media.istockphoto.com/id/136736545/photo/vanilla-and-chocolate-ice-cream.jpg?s=612x612&w=0&k=20&c=jTDN04mQjvz6GqnTzxljcidUIJOqry1z_TGqPKpeUWc=", "Rocky Road Adventure", 260, 5.0, 5 },
                    { 50, "A perfect balance of sweet and salty, featuring smooth caramel ice cream with ribbons of salted caramel for an irresistible combination.", "https://media.istockphoto.com/id/800853362/photo/salted-caramel-ice-creams-on-blue-plate.jpg?s=612x612&w=0&k=20&c=Kb4bSGQ6HzHlvMAd3TtH5O88Ux21SSVEQ9xr_z3iXUk=", "Salted Caramel Swirl", 220, 4.0, 5 },
                    { 51, "Made with Authenthic South Indian Masala serves 1-2 members", "https://res.cloudinary.com/swiggy/image/upload/fl_lossy,f_auto,q_auto/qsyeowqz2fhv2lynrrrj", "Chicken Briyani", 200, 4.5, 6 },
                    { 52, "Made with Authenthic South Indian Masala serves 1-2 members ", "https://cdn.wallpapersafari.com/20/62/Ae0M1H.jpg", "Mutton Briyani", 300, 4.4000000000000004, 6 },
                    { 53, "Made with Authentic Dindigul Style Masala serves 1-2 members ", "https://thalappakatti.com/wp-content/uploads/cache/2017/01/thalappakatti-chicken-biriyani-bone/2415692594.jpg", "Seerga Samba Chicken Briyani", 210, 4.2000000000000002, 6 },
                    { 54, "Made with Authentic Dindigul Style Masala serves 1-2 members", "https://i.ytimg.com/vi/tqxhem905W8/maxresdefault.jpg", "Seeraga Samba Mutton Briyani", 320, 4.4000000000000004, 6 },
                    { 55, "Made with Authentic Nadan Style Masala serves 1-2 members", "https://static.toiimg.com/thumb/imgsize-23456,msid-65090479,width-600,resizemode-4/65090479.jpg", "Malabar Chicken Briyani", 200, 4.0, 6 },
                    { 56, " Made with Authentic Nadan Style Masala Serves 1-2 members", "https://th.bing.com/th/id/OIP.sTlJ2Ze5yPEr1ObPC1zeDAHaE8?w=267&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", "Thalassery Fish Briyani", 280, 4.2999999999999998, 6 },
                    { 57, "Made with Authentic Natti Style Masala serves 1-2 members", "https://imgmedia.lbb.in/71525155_2455992388056731_1131146665150196823_n_1579589353176.jpg", "Natti Style Chicken Donne Briyani", 180, 4.2000000000000002, 6 },
                    { 58, "Made with Authentic Natti Style Masala serves 1-2 members", "https://th.bing.com/th/id/OIP.Y5SpomsWgRo_A5d4NlliCgHaGV?w=215&h=184&c=7&r=0&o=5&dpr=1.3&pid=1.7", "Natti Style Mutton Donne Briyani", 250, 4.2999999999999998, 6 },
                    { 59, "Made With Authenthic Hyderabadi Masala Serves 1-2 Members", "https://www.mistay.in/travel-blog/content/images/2020/07/hyderbadi-biriyani-1.jpg", "Hyderabadi Dum Briyani", 240, 4.7999999999999998, 6 },
                    { 60, "Authentic Arabic Style Mandi Briyani Serves 2-3 Members", "https://as2.ftcdn.net/v2/jpg/02/58/75/49/1000_F_258754992_ZxPmBBXh4aJh7IJs6VLmNTIQOdACBOub.jpg", "Chicken Mandi Briyani", 750, 4.5, 6 },
                    { 61, "Three Pieces poori, Wheat based deep fried fluffy dish served with potato bhaji and coconut Chuntney.", "https://thumbs.dreamstime.com/b/puri-sabji-poori-sabzi-indian-snack-indian-fried-bread-served-spicy-vegetable-curry-spicy-pickles-delicious-looking-216032342.jpg", "Poori", 120, 4.0, 7 },
                    { 62, "14 pieces of small sized idlies dunked with home-made dal spiced sambar topped with ghee.", "https://thumbs.dreamstime.com/b/mini-idli-south-indian-breakfast-56223774.jpg", "Mini Idli ", 80, 4.0999999999999996, 7 },
                    { 63, "Dosa topped with aloo masala. Served with Spiced sambar and coconut chutney.", "https://png.pngtree.com/background/20230612/original/pngtree-dosa-is-sitting-on-a-plate-and-sauce-picture-image_3176179.jpg", "Masala Dosa", 130, 3.7999999999999998, 7 },
                    { 64, "Crispy Dosa made with our nutritious home made fermented batter. It is served with Sambar and Chutney.", "https://t4.ftcdn.net/jpg/04/05/17/93/360_F_405179317_SCBiHuIam7n4LpeGQZVJxuKehh63hKfz.jpg", "Plain Dosa", 100, 4.4000000000000004, 7 },
                    { 66, "A sweet dish made of rava/semolina with nuts and ghee.", "https://t3.ftcdn.net/jpg/04/44/01/32/360_F_444013221_kqswLVkqvJpbPmEaDebxycR4rbxg80FN.jpg", "Kesari Bath", 85, 4.2999999999999998, 7 },
                    { 67, "Indulge in our little extra long dosa topped with pure butter that melts in to the dosa.", "https://thumbs.dreamstime.com/b/butter-masala-dosa-south-indian-traditional-popular-crepe-filling-mixture-mashed-potatoes-fried-onions-topping-223997600.jpg", "Butter dosa", 125, 4.0, 7 },
                    { 68, "A popular South Indian rice based dish made of dal, pepper, ghee and cashewnut.", "https://t4.ftcdn.net/jpg/05/76/25/67/360_F_576256741_gpNzOOtXk5BDR63fFBonDK5grE2x8uJB.jpg", "Ven Pongal", 110, 4.2999999999999998, 7 },
                    { 69, "A combo of Upuma and Kesari to give you the right mix of sweet and spice for your day.", "https://s3-ap-southeast-1.amazonaws.com/asia.urbanpiper.com/media/bizmedia/2021/03/02/Chow_C_Bath_COMPRESSED.jpg", "Chow Chow Bath", 120, 4.2999999999999998, 7 },
                    { 70, "A Typical South-Indian Filter Coffee is served, which comes in a Chai Flask. Ideally served 3-4 people.", "https://img.freepik.com/premium-photo/south-indian-filter-coffee-served-traditional-brass-stainless-steel-cup_466689-83531.jpg", "South Indian Filter Coffee", 115, 4.2999999999999998, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "fooditems",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
