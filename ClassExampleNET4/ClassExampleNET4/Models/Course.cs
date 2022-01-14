namespace ClassExampleNET4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
      //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

      
    }
}
