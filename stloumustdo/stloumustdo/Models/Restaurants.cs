using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stloumustdo.Models
{
    public class Restaurants
    {

        public Restaurants()
        {
            BucketList = new HashSet<BucketList>();
        }

        [Key]
        public int RestaurantId { get; set; }

        public string RestaurantName { get; set;}

        public string RestaurantType { get; set; }

        public string PriceRange { get; set;}

        public string Neighborhood { get; set;}

        public string WebsiteUrl { get; set;}

        public string ResturauntAddress { get; set; }


       public int BucketListId { get; set; }
        [ForeignKey("BucketId")]
       public virtual ICollection<BucketList> BucketList { get; set; }


        // an attraction can be on many diffrent bucket lists

        // public virtual ResturauntHours Hours {get; set;}
    }
}
