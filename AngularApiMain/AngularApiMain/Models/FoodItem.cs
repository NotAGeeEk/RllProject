namespace AngularApiMain.Models

    {
        public class FoodItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; } // New property for food item description
            public double Rating { get; set; } // New property for food item rating
            public string ImageUrl { get; set; }
            public int Price { get; set; }
            public int RestaurantId { get; set; } // Foreign key to associate with Restaurant
        }
    }


