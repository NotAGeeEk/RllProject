﻿// <auto-generated />
using AngularApiMain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularApiMain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231004180237_r5")]
    partial class r5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AngularApiMain.Models.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("fooditems", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Creamy lentils cooked with spices.",
                            ImageUrl = "https://myfoodstory.com/wp-content/uploads/2018/08/Dal-Makhani-New-3.jpg",
                            Name = "Dal Makhni",
                            Price = 225,
                            Rating = 4.5,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Paneer cooked in a rich tomato-based gravy.",
                            ImageUrl = "https://myfoodstory.com/wp-content/uploads/2022/04/Shahi-Paneer-4.jpg",
                            Name = "Shahi Paneer",
                            Price = 250,
                            Rating = 4.4000000000000004,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Creamy paneer dish cooked in a handi.",
                            ImageUrl = "https://enjoyinfourseason.com/wp-content/uploads/2022/05/Fourseason-HANDI-PANEER.jpg",
                            Name = "Handi Paneer",
                            Price = 270,
                            Rating = 4.5999999999999996,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Fried bread with spicy chickpea curry.",
                            ImageUrl = "https://img-global.cpcdn.com/recipes/1d9ce5d3344e6a34/1200x630cq70/photo.jpg",
                            Name = "Chole Bhature",
                            Price = 120,
                            Rating = 4.2000000000000002,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Soft and buttery Indian flatbread.",
                            ImageUrl = "https://simmertoslimmer.com/wp-content/uploads/2020/02/Naan-Bread.jpg",
                            Name = "Butter Naan",
                            Price = 70,
                            Rating = 4.2999999999999998,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Traditional Indian flatbread made with gram flour.",
                            ImageUrl = "https://aplateofhappiness.files.wordpress.com/2017/08/img_5666.jpg?w=1024",
                            Name = "Missi Roti",
                            Price = 50,
                            Rating = 4.0,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "Dessert made from paneer in sweet milk.",
                            ImageUrl = "https://www.milkmaid.in/sites/default/files/2020-10/Rasmalai-590x436_0.jpg",
                            Name = "Rasmalai",
                            Price = 100,
                            Rating = 4.7000000000000002,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Delicious cake for dessert.",
                            ImageUrl = "https://tatyanaseverydayfood.com/wp-content/uploads/2018/07/Summer-Sangria-Cake-4.jpg",
                            Name = "Cake",
                            Price = 300,
                            Rating = 4.2000000000000002,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 9,
                            Description = "Refreshing cola drink.",
                            ImageUrl = "https://www.mashed.com/img/gallery/a-can-of-coca-cola-is-being-sold-for-over-300000/l-intro-1683831628.jpg",
                            Name = "Coke",
                            Price = 70,
                            Rating = 4.0,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "Creamy and sweet ice cream.",
                            ImageUrl = "https://www.milkmaid.in/sites/default/files/2023-04/Mango-IceCream-385x619.jpg",
                            Name = "IceCream",
                            Price = 130,
                            Rating = 4.5,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 11,
                            Description = "Vegetarian burger with fresh veggies.",
                            ImageUrl = "https://i.pinimg.com/564x/23/ed/80/23ed80fa26efafc1b694094243b0e0bd.jpg",
                            Name = "Veg Burger",
                            Price = 80,
                            Rating = 4.2000000000000002,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 12,
                            Description = "Crispy and crunchy burger with a special sauce.",
                            ImageUrl = "https://freepngimg.com/thumb/burger%20sandwich/16-hamburger-burger-png-image-mac-burger.png",
                            Name = "Crispy Burger",
                            Price = 150,
                            Rating = 4.0999999999999996,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 13,
                            Description = "Burger with cheesy goodness.",
                            ImageUrl = "https://atlas-content-cdn.pixelsquid.com/stock-images/cheese-burger-q1yoznC-600.jpg",
                            Name = "Cheese Burger",
                            Price = 110,
                            Rating = 4.2999999999999998,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 14,
                            Description = "Double the cheese for double the delight.",
                            ImageUrl = "https://freepngimg.com/download/burger/159187-burger-double-cheese-free-png-hq.png",
                            Name = "Double Cheese Burger",
                            Price = 150,
                            Rating = 4.4000000000000004,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 15,
                            Description = "Burger with delicious chicken patty.",
                            ImageUrl = "https://5.imimg.com/data5/MK/LI/GLADMIN-25266019/chickan-fillet-burger-500x500.png",
                            Name = "Chicken Burger",
                            Price = 170,
                            Rating = 4.0,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 16,
                            Description = "Burger with a spicy kick of pepper.",
                            ImageUrl = "https://png.pngtree.com/png-clipart/20230511/original/pngtree-black-pepper-burger-breakfast-png-image_9157650.png",
                            Name = "Pepper Burger",
                            Price = 190,
                            Rating = 4.0999999999999996,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 17,
                            Description = "Burger with corn filling.",
                            ImageUrl = "https://cdn.grofers.com/cdn-cgi/image/f=auto,fit=scale-down,q=70,metadata=none,w=1080/assets/search/usecase/corn_burger_zdish.png",
                            Name = "Corn Burger",
                            Price = 135,
                            Rating = 4.2000000000000002,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 18,
                            Description = "Burger with roasted ingredients.",
                            ImageUrl = "https://images.squarespace-cdn.com/content/v1/5e4a5d2f4e209873477bec60/1595251038677-148SLUYKOHKRWLHCB804/Capture5.PNG",
                            Name = "Roasted Burger",
                            Price = 146,
                            Rating = 4.2999999999999998,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 19,
                            Description = "Refreshing cola drink.",
                            ImageUrl = "https://wdsgroup.co.uk/wp-content/uploads/2022/09/Classic-Coke-GLASS-200ml-x-24.jpg",
                            Name = "Coke",
                            Price = 120,
                            Rating = 4.0,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 20,
                            Description = "Delicious brownie cake for dessert.",
                            ImageUrl = "https://www.modernfarmhouseeats.com/wp-content/uploads/2022/03/brownie-cake-15.jpg",
                            Name = "Brownie Cake",
                            Price = 140,
                            Rating = 4.5,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 21,
                            Description = "Pizza with sweet corn toppings.",
                            ImageUrl = "https://api.pizzahut.io/v1/content/en-in/in-1/images/pizza/classic-corn-pan-personal.7c80196383b32e2ad5715646c1b12df8.1.png",
                            Name = "SweetCorn Pizza",
                            Price = 280,
                            Rating = 4.5999999999999996,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 22,
                            Description = "Pizza with capsicum and cheese.",
                            ImageUrl = "https://s3.ap-south-1.amazonaws.com/shopnowchat.com/Medium/637845105407588077_CapsicumPizza.jpg",
                            Name = "Capsicum Pizza",
                            Price = 290,
                            Rating = 4.5,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 23,
                            Description = "Pizza with mozzarella cheese and veggies.",
                            ImageUrl = "https://img.livestrong.com/375/photos.demandstudios.com/getty/article/228/16/182279111.jpg",
                            Name = "Mozeralla cheese pizza with veggies",
                            Price = 310,
                            Rating = 4.4000000000000004,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 24,
                            Description = "Pizza with double cheese burst.",
                            ImageUrl = "https://salasdaily.com/cdn/shop/products/cheese-burst-pizza2.jpg?v=1669967224",
                            Name = "Double CheeseBurst Pizza",
                            Price = 290,
                            Rating = 4.5999999999999996,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 25,
                            Description = "Pizza with paneer toppings.",
                            ImageUrl = "https://i.ytimg.com/vi/J-rmvoWfteo/mqdefault.jpg",
                            Name = "Paneer Pizza",
                            Price = 285,
                            Rating = 4.2999999999999998,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 26,
                            Description = "Classic Margherita pizza with tomatoes and basil.",
                            ImageUrl = "https://pbs.twimg.com/media/BL5Z8p0CMAAvCQ_?format=jpg&name=900x900",
                            Name = "Margherita pizza",
                            Price = 350,
                            Rating = 4.2000000000000002,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 27,
                            Description = "Pizza with cheesy chicken and pasta toppings.",
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/dominos-menu-items-are-shown-on-october-12-2017-in-chicago-news-photo-860662534-1544206128.jpg",
                            Name = "Cheesy chicken pasta pizza",
                            Price = 410,
                            Rating = 4.5,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 28,
                            Description = "Refreshing cola drink.",
                            ImageUrl = "https://spicecravings.com/wp-content/uploads/2022/06/Masala-Coke-1.jpg",
                            Name = "Coke",
                            Price = 140,
                            Rating = 4.0,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 29,
                            Description = "Molten lava cake for dessert.",
                            ImageUrl = "https://simplyhomecooked.com/wp-content/uploads/2022/01/chocolate-lava-cake-18.jpg",
                            Name = "Lava Cake",
                            Price = 180,
                            Rating = 4.7000000000000002,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 30,
                            Description = "Creamy and sweet ice cream.",
                            ImageUrl = "https://uploads-ssl.webflow.com/5e9ebc3fff165933f19fbdbe/61b31c9d289e22335b6753b2_Ice%20Cream%202.jpg",
                            Name = "IceCream",
                            Price = 245,
                            Rating = 4.4000000000000004,
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("AngularApiMain.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("restaurants", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Since 1978, Eat Sweet and Talk Sweetly.",
                            ImageUrl = "https://i.pinimg.com/originals/7d/74/19/7d7419496c7c143aadfbcffcfd6c2812.png",
                            Name = "Radhika",
                            Rating = 4.5,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Be A King Like Burger King.",
                            ImageUrl = "https://www.shutterstock.com/shutterstock/photos/2129642369/display_1500/stock-photo-amsterdam-netherlands-feb-burger-set-from-burger-king-restaurant-burger-king-s-2129642369.jpg",
                            Name = "Burger King",
                            Rating = 4.0,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "It's All About Domino's Pizza.....",
                            ImageUrl = "https://smartcanucks.ca/wp-content/uploads/2015/12/dominos-pizza.jpg",
                            Name = "Dominos",
                            Rating = 4.2000000000000002,
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("AngularApiMain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("AngularApiMain.Models.FoodItem", b =>
                {
                    b.HasOne("AngularApiMain.Models.Restaurant", null)
                        .WithMany("FoodItems")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AngularApiMain.Models.Restaurant", b =>
                {
                    b.Navigation("FoodItems");
                });
#pragma warning restore 612, 618
        }
    }
}
