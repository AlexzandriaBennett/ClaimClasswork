using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stloumustdo.Models
{
    public class BucketList
    {
        public BucketList()
        {
            Restaurants = new HashSet<Restaurants>();
            Cafes = new HashSet<Cafe>();
            Attractions = new HashSet<LocalAttraction>();
            Outdoors = new HashSet<StatewideOutdoors>();
        }

        [Key]
        public int BucketId { get; set; }

        public string Owner { get; set; }
        //possible reference key to user profile model 

        public int ResturauntId { get; set; }
        [ForeignKey("RestaurantId")]
        public virtual ICollection<Restaurants> Restaurants { get; set; }

        public int CafeId { get; set; }
        [ForeignKey("CafeId")]
        public virtual ICollection<Cafe> Cafes { get; set; }

        public int AttractionId { get; set; }
        [ForeignKey("AttractionId")]
        public virtual ICollection<LocalAttraction> Attractions { get; set; }

        public int OutdoorId { get; set; }
        [ForeignKey("OutdoorId")]
        public virtual ICollection<StatewideOutdoors> Outdoors { get; set; }






    }
}
