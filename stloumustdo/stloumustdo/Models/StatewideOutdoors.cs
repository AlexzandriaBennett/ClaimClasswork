using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stloumustdo.Models
{
    public class StatewideOutdoors
    {
        public StatewideOutdoors()
        {
            BucketList = new HashSet<BucketList>();
        }

        [Key]
        public int OutdoorId { get; set; }

        public string OutdoorName { get; set; }

        public string DistanceFromSTL { get; set; }

        public string OutdoorUrl {get ; set; }  


       public string Address { get; set; }

        public int BucketListId { get; set; }
        [ForeignKey("BucketId")]
        public virtual ICollection<BucketList> BucketList { get; set; }

        // an attraction can be on many diffrent bucket lists


        // public DateTime? When { get; set; }

    }
}
