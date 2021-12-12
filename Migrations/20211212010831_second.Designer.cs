﻿// <auto-generated />
using System;
using Lab4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab4.Migrations
{
    [DbContext(typeof(SchoolCommunityContext))]
    [Migration("20211212010831_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommunityStudent", b =>
                {
                    b.Property<string>("CommunitiesID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StudentsID")
                        .HasColumnType("int");

                    b.HasKey("CommunitiesID", "StudentsID");

                    b.HasIndex("StudentsID");

                    b.ToTable("CommunityStudent");
                });

            modelBuilder.Entity("Lab4.Models.Ads", b =>
                {
                    b.Property<int>("AdsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdsId");

                    b.ToTable("AdsImages");
                });

            modelBuilder.Entity("Lab4.Models.Community", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Communities");
                });

            modelBuilder.Entity("Lab4.Models.CommunityMembership", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<string>("CommunityID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StudentID", "CommunityID");

                    b.HasIndex("CommunityID");

                    b.ToTable("CommunityMemberships");
                });

            modelBuilder.Entity("Lab4.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CommunityStudent", b =>
                {
                    b.HasOne("Lab4.Models.Community", null)
                        .WithMany()
                        .HasForeignKey("CommunitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab4.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab4.Models.CommunityMembership", b =>
                {
                    b.HasOne("Lab4.Models.Community", "Community")
                        .WithMany("CommunityMemberships")
                        .HasForeignKey("CommunityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab4.Models.Student", "Student")
                        .WithMany("CommunityMemberships")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Community");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Lab4.Models.Community", b =>
                {
                    b.Navigation("CommunityMemberships");
                });

            modelBuilder.Entity("Lab4.Models.Student", b =>
                {
                    b.Navigation("CommunityMemberships");
                });
#pragma warning restore 612, 618
        }
    }
}