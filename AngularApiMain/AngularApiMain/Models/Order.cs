using System.ComponentModel.DataAnnotations;

namespace AngularApiMain.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int RestaurantId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string OrderTime { get; set; }

        [Required]
        public string Food { get; set; }
        
        [Required]
        public string Status { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string Review { get; set; }
        // New property fo
    }
}
