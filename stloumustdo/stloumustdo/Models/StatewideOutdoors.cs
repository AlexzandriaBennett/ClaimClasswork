using System.ComponentModel.DataAnnotations;

namespace stloumustdo.Models
{
    public class StatewideOutdoors
    {
        [Key]
        public int OutdoorId { get; set; }

        public string OutdoorName { get; set; }

        public string DistanceFromSTL { get; set; }

        public string OutdoorUrl {get ; set; }  


       public string Address { get; set; }


        // public DateTime? When { get; set; }

    }
}
