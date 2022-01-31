using System.ComponentModel.DataAnnotations;

namespace stloumustdo.Models
{
    public class LocalAttraction
    {
        [Key]
        public int AttractionId { get; set; }

        public string AttractionName { get; set; }

        public string Neighborhood { get; set; }

        public string AttractionUrl { get; set; }

        public string Address { get; set; }


        //public string PriceRange { get; set; }

        //public string Tickets { get; set; }



        //public AttractionHours Hours {get; set;}
    }
}
