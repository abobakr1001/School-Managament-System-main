﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagment.Infrastructure.Data;

#nullable disable

namespace SchoolManagment.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240730133656_AddIdentity")]
    partial class AddIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"));

                    b.Property<int?>("InsId")
                        .HasColumnType("int");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.HasIndex("InsId")
                        .IsUnique()
                        .HasFilter("[InsId] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.DepartmentSubject", b =>
                {
                    b.Property<int>("SubId")
                        .HasColumnType("int");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.HasKey("SubId", "DeptId");

                    b.HasIndex("DeptId");

                    b.ToTable("DepartmentSubjects");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Identity.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Instructor", b =>
                {
                    b.Property<int>("InstId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Salary")
                        .HasColumnType("float");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("int");

                    b.HasKey("InstId");

                    b.HasIndex("DeptId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Student", b =>
                {
                    b.Property<int>("StudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudId"));

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("NameAr")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NameEn")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudId");

                    b.HasIndex("DeptId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.StudentSubject", b =>
                {
                    b.Property<int>("SubId")
                        .HasColumnType("int");

                    b.Property<int>("StudId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Grade")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SubId", "StudId");

                    b.HasIndex("StudId");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Subject", b =>
                {
                    b.Property<int>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubId"));

                    b.Property<DateTime?>("Period")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectNameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.SubjectInsturctor", b =>
                {
                    b.Property<int>("SubId")
                        .HasColumnType("int");

                    b.Property<int>("InsId")
                        .HasColumnType("int");

                    b.HasKey("SubId", "InsId");

                    b.HasIndex("InsId");

                    b.ToTable("SubjectInsturctor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagment.Data.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Department", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Instructor", "Instructor")
                        .WithOne("DepartmentManage")
                        .HasForeignKey("SchoolManagment.Data.Entities.Department", "InsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.DepartmentSubject", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Department", "Department")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagment.Data.Entities.Subject", "Subject")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Instructor", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DeptId");

                    b.HasOne("SchoolManagment.Data.Entities.Instructor", "Supervisor")
                        .WithMany("SupervisedInstructors")
                        .HasForeignKey("SupervisorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Department");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Student", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.StudentSubject", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagment.Data.Entities.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.SubjectInsturctor", b =>
                {
                    b.HasOne("SchoolManagment.Data.Entities.Instructor", "Instructor")
                        .WithMany("SubjectInsturctors")
                        .HasForeignKey("InsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagment.Data.Entities.Subject", "Subject")
                        .WithMany("SubjectInsturctors")
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Department", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Instructor", b =>
                {
                    b.Navigation("DepartmentManage")
                        .IsRequired();

                    b.Navigation("SubjectInsturctors");

                    b.Navigation("SupervisedInstructors");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("SchoolManagment.Data.Entities.Subject", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("StudentSubjects");

                    b.Navigation("SubjectInsturctors");
                });
#pragma warning restore 612, 618
        }
    }
}
