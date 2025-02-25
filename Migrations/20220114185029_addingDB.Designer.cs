﻿// <auto-generated />
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220114185029_addingDB")]
    partial class addingDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("totalHours")
                        .HasColumnType("int");

                    b.HasKey("courseId");

                    b.ToTable("tblCourse");
                });

            modelBuilder.Entity("FinalProject.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("studentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("studentId");

                    b.ToTable("tblStudent");
                });

            modelBuilder.Entity("FinalProject.Models.StudentCourse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("courseId");

                    b.HasIndex("studentId");

                    b.ToTable("tblStudentCourse");
                });

            modelBuilder.Entity("FinalProject.Models.StudentCourse", b =>
                {
                    b.HasOne("FinalProject.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FinalProject.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("FinalProject.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
