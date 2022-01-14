using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreDBImport.Models
{
    [Table("Teacher")]
    public partial class Teacher
    {
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public int StaffId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Specialty { get; set; }

        [InverseProperty(nameof(Course.Teacher))]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
