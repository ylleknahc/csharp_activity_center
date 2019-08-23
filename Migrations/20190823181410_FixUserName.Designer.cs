﻿// <auto-generated />
using System;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeltExam.Migrations
{
    [DbContext(typeof(BeltExamContext))]
    [Migration("20190823181410_FixUserName")]
    partial class FixUserName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BeltExam.Hangout", b =>
                {
                    b.Property<int>("HangoutId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CreatorId");

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("Duration");

                    b.Property<string>("DurationType");

                    b.Property<string>("Time");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("HangoutId");

                    b.HasIndex("CreatorId");

                    b.ToTable("hangouts");
                });

            modelBuilder.Entity("BeltExam.HangoutParticipants", b =>
                {
                    b.Property<int>("HangoutParticipantId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("HangoutId")
                        .IsRequired();

                    b.Property<int?>("ParticipantId")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("HangoutParticipantId");

                    b.HasIndex("HangoutId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("hangoutParticipants");
                });

            modelBuilder.Entity("BeltExam.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BeltExam.Hangout", b =>
                {
                    b.HasOne("BeltExam.User", "Creator")
                        .WithMany("HangoutsCreated")
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("BeltExam.HangoutParticipants", b =>
                {
                    b.HasOne("BeltExam.Hangout", "Hangout")
                        .WithMany("HangoutParticipants")
                        .HasForeignKey("HangoutId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeltExam.User", "Participant")
                        .WithMany("HangoutsAsParticipants")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
