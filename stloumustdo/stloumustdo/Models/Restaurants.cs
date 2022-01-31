using System.ComponentModel.DataAnnotations;

namespace stloumustdo.Models
{
    public class Restaurants
    {

        [Key]
        public int RestaurantId { get; set; }

        public string RestaurantName { get; set;}

        public string RestaurantType { get; set; }

        public string PriceRange { get; set;}

        public string Neighborhood { get; set;}

        public string WebsiteUrl { get; set;}

        public string ResturauntAddress { get; set; }

        // public virtual ResturauntHours Hours {get; set;}
    }
}
