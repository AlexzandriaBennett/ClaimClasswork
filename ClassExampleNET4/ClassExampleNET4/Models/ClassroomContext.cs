using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClassExampleNET4.Models
{
    public partial class ClassroomContext : DbContext
    {
        public ClassroomContext()
            : base("name=ClassroomContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Specialty)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.TeacherId)
                .WillCascadeOnDelete(false);
        }
    }
}
