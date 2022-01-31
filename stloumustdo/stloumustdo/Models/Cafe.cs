using System.ComponentModel.DataAnnotations;

namespace stloumustdo.Models
{
    public class Cafe
    {
        [Key]
        public int CafeId { get; set; }

        public string CafeName { get; set; }

        public string Neighborhood { get; set; }   
        
        public string WebsiteUrl { get; set; }


        public string Address { get; set; }

        // public virtual CafeHours Hours {get; set;}

    }
}
