using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreDBImport.Models
{
    public partial class PracticeDBContext : DbContext
    {
        public PracticeDBContext()
        {
        }

        public PracticeDBContext(DbContextOptions<PracticeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentCourse> StudentCourses { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<Staff> Staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-U55QG3CM;Database=practiceDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Course__TeacherI__571DF1D5");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.Property(e => e.StudentId).ValueGeneratedNever();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentCo__Cours__5535A963");

                entity.HasOne(d => d.Student)
                    .WithOne(p => p.StudentCourse)
                    .HasForeignKey<StudentCourse>(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentCo__Stude__5629CD9C");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.StaffId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
