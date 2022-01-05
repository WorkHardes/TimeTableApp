﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimetableOfClasses.Infrastructure;

namespace TimetableOfClasses.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220105102922_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimetableOfClasses.Domain.AcademicPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumOfLabs")
                        .HasColumnType("int");

                    b.Property<int>("NumOfLectures")
                        .HasColumnType("int");

                    b.Property<int>("NumOfPractices")
                        .HasColumnType("int");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AcademicPlans");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Audience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AudienceNum")
                        .HasColumnType("int");

                    b.Property<Guid>("TimeTableId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TimeTableId");

                    b.ToTable("Audiences");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.ClassesTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClassesTimeNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TimeTableId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TimeTableId");

                    b.ToTable("ClassesTimes");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcademicPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GroupNum")
                        .HasColumnType("int");

                    b.Property<int>("NumOfStudent")
                        .HasColumnType("int");

                    b.Property<Guid>("TimeTableId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AcademicPlanId");

                    b.HasIndex("TimeTableId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Lecturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TimeTableId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TimeTableId");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Semester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcademicPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TimeTableId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcademicPlanId");

                    b.HasIndex("TimeTableId");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcademicPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TimeTableId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AcademicPlanId");

                    b.HasIndex("TimeTableId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.TimeTable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AudienceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassesTimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DayOfTheWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LecturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TimeTables");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Audience", b =>
                {
                    b.HasOne("TimetableOfClasses.Domain.TimeTable", "TimeTable")
                        .WithMany("Audiences")
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.ClassesTime", b =>
                {
                    b.HasOne("TimetableOfClasses.Domain.TimeTable", "TimeTable")
                        .WithMany("ClassesTimes")
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Group", b =>
                {
                    b.HasOne("TimetableOfClasses.Domain.AcademicPlan", "AcademicPlan")
                        .WithMany("Groups")
                        .HasForeignKey("AcademicPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimetableOfClasses.Domain.TimeTable", "TimeTable")
                        .WithMany("Groups")
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicPlan");

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Lecturer", b =>
                {
                    b.HasOne("TimetableOfClasses.Domain.TimeTable", "TimeTable")
                        .WithMany("Lecturers")
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Semester", b =>
                {
                    b.HasOne("TimetableOfClasses.Domain.AcademicPlan", "AcademicPlan")
                        .WithMany("Semesters")
                        .HasForeignKey("AcademicPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimetableOfClasses.Domain.TimeTable", "TimeTable")
                        .WithMany()
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicPlan");

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.Subject", b =>
                {
                    b.HasOne("TimetableOfClasses.Domain.AcademicPlan", "AcademicPlan")
                        .WithMany("Subjects")
                        .HasForeignKey("AcademicPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimetableOfClasses.Domain.TimeTable", "TimeTable")
                        .WithMany("Subjects")
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicPlan");

                    b.Navigation("TimeTable");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.AcademicPlan", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Semesters");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("TimetableOfClasses.Domain.TimeTable", b =>
                {
                    b.Navigation("Audiences");

                    b.Navigation("ClassesTimes");

                    b.Navigation("Groups");

                    b.Navigation("Lecturers");

                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
