﻿// <auto-generated />
using MaplicationAPI.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MaplicationAPI.Migrations
{
    [DbContext(typeof(MaplicationContext))]
    partial class MaplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Attendee", b =>
                {
                    b.Property<int>("AttendeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Chips");

                    b.Property<string>("Degree");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Resume");

                    b.Property<string>("University");

                    b.Property<string>("UserId");

                    b.HasKey("AttendeeId");

                    b.ToTable("Attendee");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Chips");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("Logo");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("StateId");

                    b.Property<string>("Street");

                    b.Property<int?>("StreetNumber");

                    b.Property<string>("Url");

                    b.Property<string>("UserId");

                    b.Property<int?>("ZipCode");

                    b.HasKey("CompanyId");

                    b.HasIndex("StateId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Coordinator", b =>
                {
                    b.Property<int>("CoordinatorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("UserId");

                    b.HasKey("CoordinatorId");

                    b.ToTable("Coordinator");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int>("CoordinatorId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("EventTitle");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("StateId");

                    b.Property<string>("Street");

                    b.Property<int>("StreetNumber");

                    b.Property<int>("ZipCode");

                    b.HasKey("EventId");

                    b.HasIndex("CoordinatorId");

                    b.HasIndex("StateId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.JobPostings", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Chips");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<string>("JobTitle");

                    b.HasKey("JobId");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobPostings");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Map", b =>
                {
                    b.Property<int>("MapId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<string>("Image");

                    b.HasKey("MapId");

                    b.HasIndex("EventId");

                    b.ToTable("Map");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Notes", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Major");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<string>("email");

                    b.HasKey("NoteId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Recruiter", b =>
                {
                    b.Property<int>("RecruiterId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Photo");

                    b.HasKey("RecruiterId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Recruiter");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StateName");

                    b.HasKey("StateId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Tables", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<int>("Height");

                    b.Property<int>("MapId");

                    b.Property<int>("Width");

                    b.Property<int>("XCoordinate");

                    b.Property<int>("YCoordinate");

                    b.HasKey("TableId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MapId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Tags", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tag");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Token");

                    b.Property<int>("UserTypeId");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.UserTypes", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserType");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Company", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Event", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.Coordinator", "Coordinator")
                        .WithMany()
                        .HasForeignKey("CoordinatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MaplicationAPI.EntityFramework.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.JobPostings", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Map", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Notes", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.User", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Recruiter", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.Tables", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("MaplicationAPI.EntityFramework.Map", "Map")
                        .WithMany()
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MaplicationAPI.EntityFramework.User", b =>
                {
                    b.HasOne("MaplicationAPI.EntityFramework.UserTypes", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
