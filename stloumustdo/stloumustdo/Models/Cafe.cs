using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stloumustdo.Models
{
    public class Cafe
    {
        public Cafe()
        {
            BucketList = new HashSet<BucketList>();
        }

        [Key]
        public int CafeId { get; set; }

        public string CafeName { get; set; }

        public string Neighborhood { get; set; }   
        
        public string WebsiteUrl { get; set; }


        public string Address { get; set; }

        public int BucketListId { get; set; }
        [ForeignKey("BucketId")]
        public virtual ICollection<BucketList> BucketList { get; set; }

        // an attraction can be on many diffrent bucket lists

        // public virtual CafeHours Hours {get; set;}

    }
}
