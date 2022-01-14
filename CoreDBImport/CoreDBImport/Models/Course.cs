using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreDBImport.Models
{
    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Name { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        [InverseProperty("Courses")]
        public virtual Teacher Teacher { get; set; } = null!;
        [InverseProperty(nameof(StudentCourse.Course))]
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
