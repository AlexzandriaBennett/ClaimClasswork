using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreDBImport.Models
{
    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [InverseProperty("Student")]
        public virtual StudentCourse StudentCourse { get; set; } = null!;
    }
}
