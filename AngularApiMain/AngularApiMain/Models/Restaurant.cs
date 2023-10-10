using System.ComponentModel.DataAnnotations;

namespace AngularApiMain.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; } // Add this property for the restaurant image
        public string Description { get; set; } // Add this property for the restaurant description

        public List<FoodItem> FoodItems { get; set; }
       

    }
}
