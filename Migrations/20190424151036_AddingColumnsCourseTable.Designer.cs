﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectFinal101.Persistance;

namespace ProjectFinal101.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190424151036_AddingColumnsCourseTable")]
    partial class AddingColumnsCourseTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsPassed");

                    b.Property<bool?>("IsSeminar");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ReviewerId");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("SemesterId");

                    b.Property<string>("SupervisorId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode");

                    b.Property<int>("Credit");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.MarksCatagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Mark");

                    b.Property<byte>("MarkType");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MarksCatagories");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.Proposal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaOfStudy")
                        .HasMaxLength(100);

                    b.Property<string>("CompanyAddress")
                        .HasMaxLength(100);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(100);

                    b.Property<string>("ContactForSupervisor")
                        .HasMaxLength(255);

                    b.Property<string>("CvPath")
                        .HasMaxLength(300);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("FrameWorkDescription")
                        .HasMaxLength(255);

                    b.Property<string>("InternshipReason")
                        .HasMaxLength(255);

                    b.Property<string>("InternshipRefernce")
                        .HasMaxLength(100);

                    b.Property<bool?>("IsHaveInternship");

                    b.Property<string>("JobDescriotion")
                        .HasMaxLength(255);

                    b.Property<string>("Language")
                        .HasMaxLength(100);

                    b.Property<byte>("ProposalTypeId");

                    b.Property<byte>("Status");

                    b.Property<string>("StudentId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProposalTypeId");

                    b.HasIndex("StudentId");

                    b.ToTable("Proposals");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.ProposalType", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ProposalType");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("Parent");

                    b.Property<byte>("Status");

                    b.HasKey("Id");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.SemesterCatagory", b =>
                {
                    b.Property<int>("MarksCatagoryId");

                    b.Property<int>("SemesterId");

                    b.HasKey("MarksCatagoryId", "SemesterId");

                    b.HasIndex("SemesterId");

                    b.ToTable("SemesterCatagories");
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.StudentMarkMap", b =>
                {
                    b.Property<int>("MarksId");

                    b.Property<string>("StudentId");

                    b.Property<DateTime>("EntryDate");

                    b.Property<int>("Marks");

                    b.Property<string>("Remarks");

                    b.Property<string>("TeacherId");

                    b.HasKey("MarksId", "StudentId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentMarkMaps");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.ApplicationUser", b =>
                {
                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser", "Reviewer")
                        .WithMany("ReviewStudents")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProjectFinal101.Core.Models.Semester", "Semester")
                        .WithMany("Users")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser", "Supervisor")
                        .WithMany("SupervisedStudents")
                        .HasForeignKey("SupervisorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.Proposal", b =>
                {
                    b.HasOne("ProjectFinal101.Core.Models.ProposalType", "ProposalType")
                        .WithMany("Proposals")
                        .HasForeignKey("ProposalTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser", "Student")
                        .WithMany("Proposals")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.SemesterCatagory", b =>
                {
                    b.HasOne("ProjectFinal101.Core.Models.MarksCatagory", "MarksCatagory")
                        .WithMany("SemesterCatagories")
                        .HasForeignKey("MarksCatagoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectFinal101.Core.Models.Semester", "Semester")
                        .WithMany("SemesterCatagories")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectFinal101.Core.Models.StudentMarkMap", b =>
                {
                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProjectFinal101.Core.Models.ApplicationUser", "Teacher")
                        .WithMany("StudentsMark")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
