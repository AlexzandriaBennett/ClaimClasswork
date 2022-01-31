using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace brandontest.Models
{
    [Table("Staff")]
    public partial class staff
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public int Salary { get; set; }
    }
}
