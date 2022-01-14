using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreDBImport.Models
{
    [Table("StudentCourse")]
    public partial class StudentCourse
    {
        [Key]
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("StudentCourses")]
        public virtual Course Course { get; set; } = null!;
        [ForeignKey(nameof(StudentId))]
        [InverseProperty("StudentCourse")]
        public virtual Student Student { get; set; } = null!;
    }
}
