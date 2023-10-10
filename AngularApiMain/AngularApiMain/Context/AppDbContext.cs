using AngularApiMain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AngularApiMain.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Admin> Admins { get; set; }
        // DbSet for Order// DbSet for FoodItem



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Restaurant>().ToTable("restaurants");
            modelBuilder.Entity<FoodItem>().ToTable("fooditems");
            modelBuilder.Entity<Order>().ToTable("orders");
            modelBuilder.Entity<Admin>().ToTable("admins");

             // You can change the delete behavior as needed


           // Seed restaurants data
           modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Radhika",
                    RestaurantId = 1,
                    Rating = 4.5,
                    ImageUrl = "https://i.pinimg.com/originals/7d/74/19/7d7419496c7c143aadfbcffcfd6c2812.png",
                    Description = "Since 1978, Eat Sweet and Talk Sweetly."
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Burger King",
                    RestaurantId = 2,
                    Rating = 4.0,
                    ImageUrl = "https://www.shutterstock.com/shutterstock/photos/2129642369/display_1500/stock-photo-amsterdam-netherlands-feb-burger-set-from-burger-king-restaurant-burger-king-s-2129642369.jpg",
                    Description = "Be A King Like Burger King."
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Dominos",
                    RestaurantId = 3,
                    Rating = 4.2,
                    ImageUrl = "https://smartcanucks.ca/wp-content/uploads/2015/12/dominos-pizza.jpg",
                    Description = "It's All About Domino's Pizza....."
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "ShakesEra",
                    RestaurantId = 4,
                    Rating = 4.3, // Provide the appropriate rating
                    ImageUrl = "https://b.zmtcdn.com/data/pictures/7/20569307/960684662f5846e1a6d91a3255e218a9_featured_v2.jpg", // Provide the image URL
                    Description = "Where Shakes Come to Life"
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "Baskin Ice Cream",
                    RestaurantId = 5,
                    Rating = 4.4, // Provide the appropriate rating
                    ImageUrl = "https://content.jdmagicbox.com/comp/kolkata/x4/033pxx33.xx33.210811101413.v9x4/catalogue/baskin-robbins-batanagar-kolkata-ice-cream-parlours-d2mjjj2dz9.jpg", // Provide the image URL
                    Description = "Discover a World of Ice Cream"
                },

                new Restaurant
                {
                    Id = 6,
                    Name = "Biryani Junction",
                    RestaurantId = 6,
                    Rating = 4.1, // Provide the appropriate rating
                    ImageUrl = "https://images.unsplash.com/photo-1563379091339-03b21ab4a4f8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8YmlyeWFuaXxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", // Provide the image URL
                    Description = "The Home of Authentic Biryani"
                },

                new Restaurant
                {
                    Id = 7,
                    Name = "South Pride",
                    RestaurantId = 7,
                    Rating = 4.6, // Provide the appropriate rating
                    ImageUrl = "https://images.unsplash.com/photo-1668236543090-82eba5ee5976?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGRvc2F8ZW58MHx8MHx8fDA%3D&w=1000&q=80", // Provide the image URL
                    Description = "Experience South Indian Delights"
                }
            









            );
            // Seed food items data and associate them with restaurants
            modelBuilder.Entity<FoodItem>().HasData(
// Food items for Radhika (RestaurantId = 1)
// Food items for Radhika Restaurant (RestaurantId = 1)
new FoodItem
{
    Id = 1,
    Name = "Dal Makhni",
    Description = "Creamy lentils cooked with spices.",
    Rating = 4.5,
    ImageUrl = "https://myfoodstory.com/wp-content/uploads/2018/08/Dal-Makhani-New-3.jpg",
    RestaurantId = 1,
    Price = 225 // Set the price for this food item
},
new FoodItem
{
    Id = 2,
    Name = "Shahi Paneer",
    Description = "Paneer cooked in a rich tomato-based gravy.",
    Rating = 4.4,
    ImageUrl = "https://myfoodstory.com/wp-content/uploads/2022/04/Shahi-Paneer-4.jpg",
    RestaurantId = 1,
    Price = 250 // Set the price for this food item
},
new FoodItem
{
    Id = 3,
    Name = "Handi Paneer",
    Description = "Creamy paneer dish cooked in a handi.",
    Rating = 4.6,
    ImageUrl = "https://enjoyinfourseason.com/wp-content/uploads/2022/05/Fourseason-HANDI-PANEER.jpg",
    RestaurantId = 1,
    Price = 270 // Set the price for this food item
},
new FoodItem
{
    Id = 4,
    Name = "Chole Bhature",
    Description = "Fried bread with spicy chickpea curry.",
    Rating = 4.2,
    ImageUrl = "https://img-global.cpcdn.com/recipes/1d9ce5d3344e6a34/1200x630cq70/photo.jpg",
    RestaurantId = 1,
    Price = 120 // Set the price for this food item
},
new FoodItem
{
    Id = 5,
    Name = "Butter Naan",
    Description = "Soft and buttery Indian flatbread.",
    Rating = 4.3,
    ImageUrl = "https://simmertoslimmer.com/wp-content/uploads/2020/02/Naan-Bread.jpg",
    RestaurantId = 1,
    Price = 70 // Set the price for this food item
},
new FoodItem
{
    Id = 6,
    Name = "Missi Roti",
    Description = "Traditional Indian flatbread made with gram flour.",
    Rating = 4.0,
    ImageUrl = "https://aplateofhappiness.files.wordpress.com/2017/08/img_5666.jpg?w=1024",
    RestaurantId = 1,
    Price = 50 // Set the price for this food item
},
new FoodItem
{
    Id = 7,
    Name = "Rasmalai",
    Description = "Dessert made from paneer in sweet milk.",
    Rating = 4.7,
    ImageUrl = "https://www.milkmaid.in/sites/default/files/2020-10/Rasmalai-590x436_0.jpg",
    RestaurantId = 1,
    Price = 100 // Set the price for this food item
},
new FoodItem
{
    Id = 8,
    Name = "Cake",
    Description = "Delicious cake for dessert.",
    Rating = 4.2,
    ImageUrl = "https://tatyanaseverydayfood.com/wp-content/uploads/2018/07/Summer-Sangria-Cake-4.jpg",
    RestaurantId = 1,
    Price = 300 // Set the price for this food item
},
new FoodItem
{
    Id = 9,
    Name = "Coke",
    Description = "Refreshing cola drink.",
    Rating = 4.0,
    ImageUrl = "https://www.mashed.com/img/gallery/a-can-of-coca-cola-is-being-sold-for-over-300000/l-intro-1683831628.jpg",
    RestaurantId = 1,
    Price = 70 // Set the price for this food item
},
new FoodItem
{
    Id = 10,
    Name = "IceCream",
    Description = "Creamy and sweet ice cream.",
    Rating = 4.5,
    ImageUrl = "https://www.milkmaid.in/sites/default/files/2023-04/Mango-IceCream-385x619.jpg",
    RestaurantId = 1,
    Price = 130 // Set the price for this food item
},

// Food items for Burger King (RestaurantId = 2)
new FoodItem
{
    Id = 11,
    Name = "Veg Burger",
    Description = "Vegetarian burger with fresh veggies.",
    Rating = 4.2,
    ImageUrl = "https://i.pinimg.com/564x/23/ed/80/23ed80fa26efafc1b694094243b0e0bd.jpg",
    RestaurantId = 2,
    Price = 80// Set the price for this food item
},
new FoodItem
{
    Id = 12,
    Name = "Crispy Burger",
    Description = "Crispy and crunchy burger with a special sauce.",
    Rating = 4.1,
    ImageUrl = "https://freepngimg.com/thumb/burger%20sandwich/16-hamburger-burger-png-image-mac-burger.png",
    RestaurantId = 2,
    Price = 150 // Set the price for this food item
},
new FoodItem
{
    Id = 13,
    Name = "Cheese Burger",
    Description = "Burger with cheesy goodness.",
    Rating = 4.3,
    ImageUrl = "https://atlas-content-cdn.pixelsquid.com/stock-images/cheese-burger-q1yoznC-600.jpg",
    RestaurantId = 2,
    Price = 110 // Set the price for this food item
},
new FoodItem
{
    Id = 14,
    Name = "Double Cheese Burger",
    Description = "Double the cheese for double the delight.",
    Rating = 4.4,
    ImageUrl = "https://freepngimg.com/download/burger/159187-burger-double-cheese-free-png-hq.png",
    RestaurantId = 2,
    Price = 150 // Set the price for this food item
},
new FoodItem
{
    Id = 15,
    Name = "Chicken Burger",
    Description = "Burger with delicious chicken patty.",
    Rating = 4.0,
    ImageUrl = "https://5.imimg.com/data5/MK/LI/GLADMIN-25266019/chickan-fillet-burger-500x500.png",
    RestaurantId = 2,
    Price = 170 // Set the price for this food item
},
new FoodItem
{
    Id = 16,
    Name = "Pepper Burger",
    Description = "Burger with a spicy kick of pepper.",
    Rating = 4.1,
    ImageUrl = "https://png.pngtree.com/png-clipart/20230511/original/pngtree-black-pepper-burger-breakfast-png-image_9157650.png",
    RestaurantId = 2,
    Price = 190 // Set the price for this food item
},
new FoodItem
{
    Id = 17,
    Name = "Corn Burger",
    Description = "Burger with corn filling.",
    Rating = 4.2,
    ImageUrl = "https://cdn.grofers.com/cdn-cgi/image/f=auto,fit=scale-down,q=70,metadata=none,w=1080/assets/search/usecase/corn_burger_zdish.png",
    RestaurantId = 2,
    Price = 135 // Set the price for this food item
},
new FoodItem
{
    Id = 18,
    Name = "Roasted Burger",
    Description = "Burger with roasted ingredients.",
    Rating = 4.3,
    ImageUrl = "https://images.squarespace-cdn.com/content/v1/5e4a5d2f4e209873477bec60/1595251038677-148SLUYKOHKRWLHCB804/Capture5.PNG",
    RestaurantId = 2,
    Price = 146 // Set the price for this food item
},
new FoodItem
{
    Id = 19,
    Name = "Coke",
    Description = "Refreshing cola drink.",
    Rating = 4.0,
    ImageUrl = "https://wdsgroup.co.uk/wp-content/uploads/2022/09/Classic-Coke-GLASS-200ml-x-24.jpg",
    RestaurantId = 2,
    Price = 120 // Set the price for this food item
},
new FoodItem
{
    Id = 20,
    Name = "Brownie Cake",
    Description = "Delicious brownie cake for dessert.",
    Rating = 4.5,
    ImageUrl = "https://www.modernfarmhouseeats.com/wp-content/uploads/2022/03/brownie-cake-15.jpg",
    RestaurantId = 2,
    Price = 140 // Set the price for this food item
},

// Food items for Dominos (RestaurantId = 3)
new FoodItem
{
    Id = 21,
    Name = "SweetCorn Pizza",
    Description = "Pizza with sweet corn toppings.",
    Rating = 4.6,
    ImageUrl = "https://api.pizzahut.io/v1/content/en-in/in-1/images/pizza/classic-corn-pan-personal.7c80196383b32e2ad5715646c1b12df8.1.png",
    RestaurantId = 3,
    Price = 280 // Set the price for this food item
},
new FoodItem
{
    Id = 22,
    Name = "Capsicum Pizza",
    Description = "Pizza with capsicum and cheese.",
    Rating = 4.5,
    ImageUrl = "https://s3.ap-south-1.amazonaws.com/shopnowchat.com/Medium/637845105407588077_CapsicumPizza.jpg",
    RestaurantId = 3,
    Price = 290 // Set the price for this food item
},
new FoodItem
{
    Id = 23,
    Name = "Mozeralla cheese pizza with veggies",
    Description = "Pizza with mozzarella cheese and veggies.",
    Rating = 4.4,
    ImageUrl = "https://img.livestrong.com/375/photos.demandstudios.com/getty/article/228/16/182279111.jpg",
    RestaurantId = 3,
    Price = 310 // Set the price for this food item
},
new FoodItem
{
    Id = 24,
    Name = "Double CheeseBurst Pizza",
    Description = "Pizza with double cheese burst.",
    Rating = 4.6,
    ImageUrl = "https://salasdaily.com/cdn/shop/products/cheese-burst-pizza2.jpg?v=1669967224",
    RestaurantId = 3,
    Price = 290// Set the price for this food item
},
new FoodItem
{
    Id = 25,
    Name = "Paneer Pizza",
    Description = "Pizza with paneer toppings.",
    Rating = 4.3,
    ImageUrl = "https://i.ytimg.com/vi/J-rmvoWfteo/mqdefault.jpg",
    RestaurantId = 3,
    Price = 285 // Set the price for this food item
},
new FoodItem
{
    Id = 26,
    Name = "Margherita pizza",
    Description = "Classic Margherita pizza with tomatoes and basil.",
    Rating = 4.2,
    ImageUrl = "https://pbs.twimg.com/media/BL5Z8p0CMAAvCQ_?format=jpg&name=900x900",
    RestaurantId = 3,
    Price = 350 // Set the price for this food item
},
new FoodItem
{
    Id = 27,
    Name = "Cheesy chicken pasta pizza",
    Description = "Pizza with cheesy chicken and pasta toppings.",
    Rating = 4.5,
    ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/dominos-menu-items-are-shown-on-october-12-2017-in-chicago-news-photo-860662534-1544206128.jpg",
    RestaurantId = 3,
    Price = 410 // Set the price for this food item
},
new FoodItem
{
    Id = 28,
    Name = "Coke",
    Description = "Refreshing cola drink.",
    Rating = 4.0,
    ImageUrl = "https://spicecravings.com/wp-content/uploads/2022/06/Masala-Coke-1.jpg",
    RestaurantId = 3,
    Price = 140 // Set the price for this food item
},
new FoodItem
{
    Id = 29,
    Name = "Lava Cake",
    Description = "Molten lava cake for dessert.",
    Rating = 4.7,
    ImageUrl = "https://simplyhomecooked.com/wp-content/uploads/2022/01/chocolate-lava-cake-18.jpg",
    RestaurantId = 3,
    Price = 180 // Set the price for this food item
},
new FoodItem
{
    Id = 30,
    Name = "IceCream",
    Description = "Creamy and sweet ice cream.",
    Rating = 4.4,
    ImageUrl = "https://uploads-ssl.webflow.com/5e9ebc3fff165933f19fbdbe/61b31c9d289e22335b6753b2_Ice%20Cream%202.jpg",
    RestaurantId = 3,
    Price = 245 // Set the price for this food item
},

//Food item for resturant 4 
new FoodItem
{
    Id = 31,
    Name = "Classic Vanilla Bliss Shake",
    Description = "Velvety vanilla ice cream blended to perfection.",
    Rating = 4.5,
    ImageUrl = "https://img.freepik.com/free-photo/front-view-delicious-milkshake-with-yellow-background_23-2148296082.jpg?w=360&t=st=1696658844~exp=1696659444~hmac=29a27f2de60eb1158ff77250ed4a41016f010b41e916f67fe3c05fb651dd7556",
    RestaurantId = 4,
    Price = 200// Set the price for this food item
},
new FoodItem
{
    Id = 32,
    Name = "Decadent Chocolate Avalanche Shake",
    Description = "A heavenly blend of premium chocolate ice cream.",
    Rating = 4.2,
    ImageUrl = "https://img.freepik.com/free-photo/creamy-vanilla-milky-shake-with-chocolate-sauce-white-saucer_114579-10109.jpg?w=900&t=st=1696659043~exp=1696659643~hmac=e10799cbf337bf2812c5bf8881d9d3eadd1584770b6076db5343a6df612ae566",
    RestaurantId = 4,
    Price = 250 // Set the price for this food item
},
new FoodItem
{
    Id = 33,
    Name = "Strawberry Fields Forever Shake",
    Description = "Made with ripe strawberries.",
    Rating = 4.4,
    ImageUrl = "https://img.freepik.com/premium-photo/glass-fresh-strawberry-smoothie-juice-with-cream-strawberry_641698-190.jpg?size=626&ext=jpg&ga=GA1.1.698317621.1696062515&semt=ais",
    RestaurantId = 4,
    Price = 310 // Set the price for this food item
},
new FoodItem
{
    Id = 34,
    Name = "Caramel Crunch Delight Shake",
    Description = " Ice cream meets crunchy toffee bits, swirled with caramel sauce.",
    Rating = 4.1,
    ImageUrl = "https://media.istockphoto.com/id/673742908/photo/iced-caramel-latte-coffee-in-a-tall-glass.webp?b=1&s=170667a&w=0&k=20&c=KjaUNWbOesPu-ZDwk6R8xfmACAZ5lHS42vQJpIvtLRA=",
    RestaurantId = 4,
    Price = 280 // Set the price for this food item
},
new FoodItem
{
    Id = 35,
    Name = "Minty Fresh Chocolate Chip Shake",
    Description = "Mint chocolate chip ice cream Melody",
    Rating = 4.0,
    ImageUrl = "https://media.istockphoto.com/id/1407551345/photo/homemade-green-chocolate-chip-mint-milkshake.jpg?s=612x612&w=0&k=20&c=ah27-9_xwyR_oTXAMHdQlKHg-Q31ARZggwUY2ioyhd8=",
    RestaurantId = 4,
    Price = 270 // Set the price for this food item
},
new FoodItem
{
    Id = 36,
    Name = "Peanut Butter Paradise Shake",
    Description = " Creamy peanut butter and chocolate ice cream .",
    Rating = 3.9,
    ImageUrl = "https://media.istockphoto.com/id/522334972/photo/peanut-butter-banana-oat-smoothie-on-rustic-wood-with-scattered-ingredients.jpg?s=612x612&w=0&k=20&c=F_0O7J_x36jHY7-eVMYoOdjEMlnahMTH7_kDCXO6XUA=",
    RestaurantId = 4,
    Price = 290 // Set the price for this food item
},
new FoodItem
{
    Id = 37,
    Name = "Cookies 'n' Cream Dream Shake",
    Description = "A velvety blend of cookies ",
    Rating = 4.7,
    ImageUrl = "https://media.istockphoto.com/id/1308045723/photo/cold-coffee-frappuccino.jpg?s=612x612&w=0&k=20&c=drB225PkXKnjRzym-06I3rQs2dawXXb2mxsdbkj9aK0=",
    RestaurantId = 4,
    Price = 335 // Set the price for this food item
},
new FoodItem
{
    Id = 38,
    Name = "Banana Nutella Fusion Shake",
    Description = " a heavenly blend of ripe bananas",
    Rating = 4.9,
    ImageUrl = "https://media.istockphoto.com/id/1298479104/photo/chocolate-smoothie-with-choco-syrup-and-branch-of-bananas.jpg?s=612x612&w=0&k=20&c=IcFzt-i-MUYJuSpLBBUlMCi1jdBkjqxc8E0F_0fHjho=",
    RestaurantId = 4,
    Price = 246 // Set the price for this food item
},
new FoodItem
{
    Id = 39,
    Name = "Tropical Paradise Mango Shake",
    Description = "Fresh mangoes blended with creamy coconut ice cream",
    Rating = 4.8,
    ImageUrl = "https://media.istockphoto.com/id/537632144/photo/fresh-tropical-fruit-smoothie-mango-juice.jpg?s=612x612&w=0&k=20&c=HcQ1SyHOzrwe-0Aj5_pkzQPXIktjc4B4tQ5OGJPCAAM=",
    RestaurantId = 4,
    Price = 320 // Set the price for this food item
},
new FoodItem
{
    Id = 40,
    Name = "Espresso Brownie Buzz Shake",
    Description = "the Espresso Brownie Buzz Shake is a must-try. Cold-brewed espresso, brownie chunks, and coffee",
    Rating = 4.5,
    ImageUrl = "https://media.istockphoto.com/id/671860998/photo/iced-chocolate-on-glass-table-top.jpg?s=612x612&w=0&k=20&c=WMrLqNNR3IAZQVlzWTB8Df1akxorcB9a0Wj1Q5BtT3M=",
    RestaurantId = 4,
    Price = 240 // Set the price for this food item
},
//Fooditem for restaurant 5 
new FoodItem
{
    Id = 41,
    Name = "Classic Vanilla Bliss",
    Description = " A timeless favorite with a creamy, velvety texture and the pure essence of Madagascar vanilla beans..",
    Rating = 4.1,
    ImageUrl = "https://media.istockphoto.com/id/659314530/photo/sweet-vanilla-ice-cream.jpg?s=612x612&w=0&k=20&c=y6LzVSTb8lP4suQutOEgBfxtrdiBgVLfBZMb4-00qMU=",
    RestaurantId = 5,
    Price = 220// Set the price for this food item
},
new FoodItem
{
    Id = 42,
    Name = "Decadent Chocolate Fudge Brownie",
    Description = "Rich, indulgent chocolate ice cream loaded with chunks of gooey fudge brownies for the ultimate chocolate lover's delight..",
    Rating = 3.9,
    ImageUrl = "https://media.istockphoto.com/id/134203159/photo/brownie-cake.jpg?s=612x612&w=0&k=20&c=8adTLMUNTiZ3fhU9vidOv3M6mI72yPf5Gn9XQ1cHJcs=",
    RestaurantId = 5,
    Price = 240 // Set the price for this food item
},
new FoodItem
{
    Id = 43,
    Name = "Strawberry Fields Forever",
    Description = "Sweet and refreshing strawberry ice cream made from ripe, hand-picked strawberries, perfect for a taste of summer.",
    Rating = 4.8,
    ImageUrl = "https://media.istockphoto.com/id/470712118/photo/scoops-of-strawberry-ice-cream-in-a-dish-with-mint-garnish.jpg?s=612x612&w=0&k=20&c=DmrzpbV-e8tkLHuptylMJ3A4ljcBEszEOqA4vjFVwhM=",
    RestaurantId = 5,
    Price = 200 // Set the price for this food item
},
new FoodItem
{
    Id = 44,
    Name = "Mint Chocolate Chip Delight",
    Description = "Cool and refreshing mint ice cream generously studded with dark chocolate chips, providing a delightful contrast of flavors.",
    Rating = 4.4,
    ImageUrl = "https://media.istockphoto.com/id/1332759408/photo/mint-ice-cream-with-chocolate-chips.jpg?s=612x612&w=0&k=20&c=zH6oJaXiliHcqMm7LGQ--qzZ6hDgDYfwuYMr3bgcLFw=",
    RestaurantId = 5,
    Price = 280 // Set the price for this food item
},
new FoodItem
{
    Id = 45,
    Name = "Cookies 'n Cream Dream",
    Description = "Creamy vanilla ice cream blended with chunks of chocolate sandwich cookies for a satisfying crunch in every bite.",
    Rating = 4.5,
    ImageUrl = "https://media.istockphoto.com/id/154245754/photo/real-gourmet-ice-cream.jpg?s=612x612&w=0&k=20&c=QN9crvD_if0d3brbqjlCeEiBK247WYLxwkp9si6txXE=",
    RestaurantId = 5,
    Price = 290 // Set the price for this food item
},
new FoodItem
{
    Id = 46,
    Name = "Pistachio Almond Euphoria",
    Description = "Nutty pistachio ice cream blended with toasted almonds, offering a unique and delightful flavor profile.",
    Rating = 4.3,

    ImageUrl = "https://media.istockphoto.com/id/1304761771/photo/pistachio-ice-cream-with-pistachio-nuts-glass-ice-cream-bowl-on-a-dark-background-horizontal.jpg?s=612x612&w=0&k=20&c=O8uj7UYEHjbOqNqmcRscRt29NPAJrzAlU-sJx7aVpEQ=",
    RestaurantId = 5,
    Price = 280 // Set the price for this food item
},
new FoodItem
{
    Id = 47,
    Name = "Tropical Paradise Sorbet",
    Description = "A refreshing dairy-free option with a medley of tropical fruits like pineapple, mango, and passion fruit, creating a burst of exotic flavors.",
    Rating = 4.0,
    ImageUrl = "https://media.istockphoto.com/id/1051348322/photo/ice.jpg?s=1024x1024&w=is&k=20&c=Ua32dlxMO5MQ7V82kPcJ5KTHMVaiE2ZhxDA_fFZFcMs=",
    RestaurantId = 5,
    Price = 250 // Set the price for this food item
},
new FoodItem
{
    Id = 48,
    Name = "Coffee Toffee Crunch",
    Description = "Creamy coffee ice cream infused with bits of buttery toffee and a hint of espresso, perfect for coffee enthusiasts.",
    Rating = 4.6,
    ImageUrl = "https://media.istockphoto.com/id/523693554/photo/vanilla-ice-cream-with-nuts-chocolate-and-caramel.jpg?s=612x612&w=0&k=20&c=puKzTWxTrn7jM7lLZMZyhh8NW9hb5hEENzhE1Xbtjyo=",
    RestaurantId = 5,
    Price = 210 // Set the price for this food item
},
new FoodItem
{
    Id = 49,
    Name = "Rocky Road Adventure",
    Description = "A delightful mix of chocolate ice cream with marshmallows and roasted almonds, providing a satisfying combination of textures and flavors.",
    Rating = 5.0,
    ImageUrl = "https://media.istockphoto.com/id/136736545/photo/vanilla-and-chocolate-ice-cream.jpg?s=612x612&w=0&k=20&c=jTDN04mQjvz6GqnTzxljcidUIJOqry1z_TGqPKpeUWc=",
    RestaurantId = 5,
    Price = 260 // Set the price for this food item
},
new FoodItem
{
    Id = 50,
    Name = "Salted Caramel Swirl",
    Description = "A perfect balance of sweet and salty, featuring smooth caramel ice cream with ribbons of salted caramel for an irresistible combination.",
    Rating = 4.0,
    ImageUrl = "https://media.istockphoto.com/id/800853362/photo/salted-caramel-ice-creams-on-blue-plate.jpg?s=612x612&w=0&k=20&c=Kb4bSGQ6HzHlvMAd3TtH5O88Ux21SSVEQ9xr_z3iXUk=",
    RestaurantId = 5,
    Price = 220 // Set the price for this food item
},
//Food item For resturant 6
new FoodItem
{
    Id = 51,
    Name = "Chicken Briyani",
    Description = "Made with Authenthic South Indian Masala serves 1-2 members",
    Rating = 4.5,
    ImageUrl = "https://res.cloudinary.com/swiggy/image/upload/fl_lossy,f_auto,q_auto/qsyeowqz2fhv2lynrrrj",
    RestaurantId = 6,
    Price = 200// Set the price for this food item
},
new FoodItem
{
    Id = 52,
    Name = "Mutton Briyani",
    Description = "Made with Authenthic South Indian Masala serves 1-2 members ",
    Rating = 4.4,
    ImageUrl = "https://cdn.wallpapersafari.com/20/62/Ae0M1H.jpg",
    RestaurantId = 6,
    Price = 300 // Set the price for this food item
},
new FoodItem
{
    Id = 53,
    Name = "Seerga Samba Chicken Briyani",
    Description = "Made with Authentic Dindigul Style Masala serves 1-2 members ",
    Rating = 4.2,
    ImageUrl = "https://thalappakatti.com/wp-content/uploads/cache/2017/01/thalappakatti-chicken-biriyani-bone/2415692594.jpg",
    RestaurantId = 6,
    Price = 210 // Set the price for this food item
},
new FoodItem
{
    Id = 54,
    Name = "Seeraga Samba Mutton Briyani",
    Description = "Made with Authentic Dindigul Style Masala serves 1-2 members",
    Rating = 4.4,
    ImageUrl = "https://i.ytimg.com/vi/tqxhem905W8/maxresdefault.jpg",
    RestaurantId = 6,
    Price = 320 // Set the price for this food item
},
new FoodItem
{
    Id = 55,
    Name = "Malabar Chicken Briyani",
    Description = "Made with Authentic Nadan Style Masala serves 1-2 members",
    Rating = 4.0,
    ImageUrl = "https://static.toiimg.com/thumb/imgsize-23456,msid-65090479,width-600,resizemode-4/65090479.jpg",
    RestaurantId = 6,
    Price = 200 // Set the price for this food item
},
new FoodItem
{
    Id = 56,
    Name = "Thalassery Fish Briyani",
    Description = " Made with Authentic Nadan Style Masala Serves 1-2 members",
    Rating = 4.3,
    ImageUrl = "https://th.bing.com/th/id/OIP.sTlJ2Ze5yPEr1ObPC1zeDAHaE8?w=267&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
    RestaurantId = 6,
    Price = 280 // Set the price for this food item
},
new FoodItem
{
    Id = 57,
    Name = "Natti Style Chicken Donne Briyani",
    Description = "Made with Authentic Natti Style Masala serves 1-2 members",
    Rating = 4.2,
    ImageUrl = "https://imgmedia.lbb.in/71525155_2455992388056731_1131146665150196823_n_1579589353176.jpg",
    RestaurantId = 6,
    Price = 180 // Set the price for this food item
},
new FoodItem
{
    Id = 58,
    Name = "Natti Style Mutton Donne Briyani",
    Description = "Made with Authentic Natti Style Masala serves 1-2 members",
    Rating = 4.3,
    ImageUrl = "https://th.bing.com/th/id/OIP.Y5SpomsWgRo_A5d4NlliCgHaGV?w=215&h=184&c=7&r=0&o=5&dpr=1.3&pid=1.7",
    RestaurantId = 6,
    Price = 250 // Set the price for this food item
},
new FoodItem
{
    Id = 59,
    Name = "Hyderabadi Dum Briyani",
    Description = "Made With Authenthic Hyderabadi Masala Serves 1-2 Members",
    Rating = 4.8,
    ImageUrl = "https://www.mistay.in/travel-blog/content/images/2020/07/hyderbadi-biriyani-1.jpg",
    RestaurantId = 6,
    Price = 240 // Set the price for this food item
},
new FoodItem
{
    Id = 60,
    Name = "Chicken Mandi Briyani",
    Description = "Authentic Arabic Style Mandi Briyani Serves 2-3 Members",
    Rating = 4.5,
    ImageUrl = "https://as2.ftcdn.net/v2/jpg/02/58/75/49/1000_F_258754992_ZxPmBBXh4aJh7IJs6VLmNTIQOdACBOub.jpg",
    RestaurantId = 6,
    Price = 750 // Set the price for this food item
},
new FoodItem
{
    Id = 61,
    Name = "Poori",
    Description = "Three Pieces poori, Wheat based deep fried fluffy dish served with potato bhaji and coconut Chuntney.",
    Rating = 4.0,
    ImageUrl = "https://thumbs.dreamstime.com/b/puri-sabji-poori-sabzi-indian-snack-indian-fried-bread-served-spicy-vegetable-curry-spicy-pickles-delicious-looking-216032342.jpg",
    RestaurantId = 7,
    Price = 120// Set the price for this food item
},
new FoodItem
{
    Id = 62,
    Name = "Mini Idli ",
    Description = "14 pieces of small sized idlies dunked with home-made dal spiced sambar topped with ghee.",
    Rating = 4.1,
    ImageUrl = "https://thumbs.dreamstime.com/b/mini-idli-south-indian-breakfast-56223774.jpg",
    RestaurantId = 7,
    Price = 80 // Set the price for this food item
},
new FoodItem
{
    Id = 63,
    Name = "Masala Dosa",
    Description = "Dosa topped with aloo masala. Served with Spiced sambar and coconut chutney.",
    Rating = 3.8,
    ImageUrl = "https://png.pngtree.com/background/20230612/original/pngtree-dosa-is-sitting-on-a-plate-and-sauce-picture-image_3176179.jpg",
    RestaurantId = 7,
    Price = 130 // Set the price for this food item
},
new FoodItem
{
    Id = 64,
    Name = "Plain Dosa",
    Description = "Crispy Dosa made with our nutritious home made fermented batter. It is served with Sambar and Chutney.",
    Rating = 4.4,
    ImageUrl = "https://t4.ftcdn.net/jpg/04/05/17/93/360_F_405179317_SCBiHuIam7n4LpeGQZVJxuKehh63hKfz.jpg",
    RestaurantId = 7,
    Price = 100 // Set the price for this food item
},
new FoodItem
{
    Id = 65,
    Name = "Upma Kitchadi",
    Description = "This dish is made of Rava/Semolina with Dal and Other spices.",
    Rating = 3.8,
    ImageUrl = "https://thumbs.dreamstime.com/b/upma-made-samolina-rava-upma-most-famous-south-indian-breakfast-item-which-beautifully-arranged-plate-banana-216111370.jpg",
    RestaurantId = 2,
    Price = 90 // Set the price for this food item
},
new FoodItem
{
    Id = 66,
    Name = "Kesari Bath",
    Description = "A sweet dish made of rava/semolina with nuts and ghee.",
    Rating = 4.3,
    ImageUrl = "https://t3.ftcdn.net/jpg/04/44/01/32/360_F_444013221_kqswLVkqvJpbPmEaDebxycR4rbxg80FN.jpg",
    RestaurantId = 7,
    Price = 85 // Set the price for this food item
},
new FoodItem
{
    Id = 67,
    Name = "Butter dosa",
    Description = "Indulge in our little extra long dosa topped with pure butter that melts in to the dosa.",
    Rating = 4.0,
    ImageUrl = "https://thumbs.dreamstime.com/b/butter-masala-dosa-south-indian-traditional-popular-crepe-filling-mixture-mashed-potatoes-fried-onions-topping-223997600.jpg",
    RestaurantId = 7,
    Price = 125 // Set the price for this food item
},
new FoodItem
{
    Id = 68,
    Name = "Ven Pongal",
    Description = "A popular South Indian rice based dish made of dal, pepper, ghee and cashewnut.",
    Rating = 4.3,
    ImageUrl = "https://t4.ftcdn.net/jpg/05/76/25/67/360_F_576256741_gpNzOOtXk5BDR63fFBonDK5grE2x8uJB.jpg",
    RestaurantId = 7,
    Price = 110 // Set the price for this food item
},
new FoodItem
{
    Id = 69,
    Name = "Chow Chow Bath",
    Description = "A combo of Upuma and Kesari to give you the right mix of sweet and spice for your day.",
    Rating = 4.3,
    ImageUrl = "https://s3-ap-southeast-1.amazonaws.com/asia.urbanpiper.com/media/bizmedia/2021/03/02/Chow_C_Bath_COMPRESSED.jpg",
    RestaurantId = 7,
    Price = 120 // Set the price for this food item
},
new FoodItem
{
    Id = 70,
    Name = "South Indian Filter Coffee",
    Description = "A Typical South-Indian Filter Coffee is served, which comes in a Chai Flask. Ideally served 3-4 people.",
    Rating = 4.3,
    ImageUrl = "https://img.freepik.com/premium-photo/south-indian-filter-coffee-served-traditional-brass-stainless-steel-cup_466689-83531.jpg",
    RestaurantId = 7,
    Price = 115 // Set the price for this food item
}







);
            modelBuilder.Entity<Order>().HasData(
          new Order
          {
              OrderId = 1,
              RestaurantId = 1,
              UserId = 1,
              OrderTime = "Thu Oct 05 2023 00:06:25 GMT+0530 (India Standard Time)",
              Food = "[{\"name\":\"burger\",\"price\":23},{\"name\":\"pizza\",\"price\":32}]",
               Status = "Pending",
              Rating = 4.0,
              Review = " "
          },
          new Order
          {
              OrderId = 2,
              RestaurantId = 2,
              UserId = 2,
              OrderTime = "Fri Oct 06 2023 01:07:26 GMT+0530 (India Standard Time)",
              Food = "[{\"name\":\"pasta\",\"price\":22},{\"name\":\"tacos\",\"price\":12}]",
              Status = "Completed",
              Rating = 4,
              Review =" "
          }
      );



        }

    }
    }
