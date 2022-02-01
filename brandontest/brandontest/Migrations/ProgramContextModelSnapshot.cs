﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using brandontest.Models;

#nullable disable

namespace brandontest.Migrations
{
    [DbContext(typeof(ProgramContext))]
    partial class ProgramContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("brandontest.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("brandontest.Models.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("Model")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("MigrationId", "ContextKey")
                        .HasName("PK_dbo.__MigrationHistory");

                    b.ToTable("__MigrationHistory");
                });

            modelBuilder.Entity("brandontest.Models.staff", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("brandontest.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("brandontest.Models.Teacher", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("Specialty")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("StaffId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId")
                        .HasName("PK__StudentC__5E57FC83F734ED6F");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourse", (string)null);
                });

            modelBuilder.Entity("brandontest.Models.Course", b =>
                {
                    b.HasOne("brandontest.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .IsRequired()
                        .HasConstraintName("FK__Course__TeacherI__571DF1D5");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("StudentCourse", b =>
                {
                    b.HasOne("brandontest.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .IsRequired()
                        .HasConstraintName("FK__StudentCo__Cours__75A278F5");

                    b.HasOne("brandontest.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK__StudentCo__Stude__76969D2E");
                });

            modelBuilder.Entity("brandontest.Models.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}