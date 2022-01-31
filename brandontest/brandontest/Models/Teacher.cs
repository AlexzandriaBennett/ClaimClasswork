using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace brandontest.Models
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
