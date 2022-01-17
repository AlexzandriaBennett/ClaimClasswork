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
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Column("age")]
        public int Age { get; set; }

        [ForeignKey("StudentId")]
        [InverseProperty(nameof(Course.Students))]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
