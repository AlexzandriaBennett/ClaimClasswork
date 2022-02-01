using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stloumustdo.Models
{
    public class LocalAttraction
    {
        public LocalAttraction()
        {
            BucketList = new HashSet<BucketList>();
        }

        [Key]
        public int AttractionId { get; set; }

        public string AttractionName { get; set; }

        public string Neighborhood { get; set; }

        public string AttractionUrl { get; set; }

        public string Address { get; set; }

        public int BucketListId { get; set; }
        [ForeignKey("BucketId")]
        public virtual ICollection<BucketList> BucketList { get; set; }
        // an attraction can be on many diffrent bucket lists



        //public string PriceRange { get; set; }

        //public string Tickets { get; set; }



        //public AttractionHours Hours {get; set;}
    }
}
