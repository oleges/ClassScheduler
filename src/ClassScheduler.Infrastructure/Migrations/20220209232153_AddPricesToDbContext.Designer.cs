﻿// <auto-generated />
using System;
using ClassScheduler.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassScheduler.Infrastructure.Migrations
{
    [DbContext(typeof(ClassSchedulerContext))]
    [Migration("20220209232153_AddPricesToDbContext")]
    partial class AddPricesToDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RepeatInterval")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("RepeatUntil")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.LessonException", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("LessonExceptions");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("End")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.Property<int>("ClassesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClassesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("ClassStudent");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Class", b =>
                {
                    b.HasOne("ClassScheduler.Domain.Entities.Subject", "Subject")
                        .WithMany("Classes")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Lesson", b =>
                {
                    b.HasOne("ClassScheduler.Domain.Entities.Class", "Class")
                        .WithMany("Lessons")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.LessonException", b =>
                {
                    b.HasOne("ClassScheduler.Domain.Entities.Lesson", "Lesson")
                        .WithMany("LessonExceptions")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Price", b =>
                {
                    b.HasOne("ClassScheduler.Domain.Entities.Class", "Class")
                        .WithMany("Prices")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassScheduler.Domain.Entities.Currency", "Currency")
                        .WithMany("Prices")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("ClassStudent", b =>
                {
                    b.HasOne("ClassScheduler.Domain.Entities.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassScheduler.Domain.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Class", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Currency", b =>
                {
                    b.Navigation("Prices");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Lesson", b =>
                {
                    b.Navigation("LessonExceptions");
                });

            modelBuilder.Entity("ClassScheduler.Domain.Entities.Subject", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}
