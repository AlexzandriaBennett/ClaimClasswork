using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficialLab3.Models
{

    [Table("Student")]
    public partial class Student
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [ForeignKey("StudentId")]
        [InverseProperty(nameof(Course.Students))]
        public int Id { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; }
    }
}
