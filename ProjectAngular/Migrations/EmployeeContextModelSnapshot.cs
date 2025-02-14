﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectAngular.Models;

namespace ProjectAngular.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProjectAngular.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DepName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ProjectAngular.Models.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DivisionId")
                        .HasColumnType("int");

                    b.HasKey("DistrictId");

                    b.HasIndex("DivisionId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("ProjectAngular.Models.Division", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DivName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DivisionId");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("ProjectAngular.Models.EducationalInfo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CGPA")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("HighestDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassingYear")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EducationalInfos");
                });

            modelBuilder.Entity("ProjectAngular.Models.EmploymentInfo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("ReferenceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferencePhone")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmploymentInfos");
                });

            modelBuilder.Entity("ProjectAngular.Models.PersonalInfo", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("DivisionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DistrictId");

                    b.ToTable("PersonalInfos");
                });

            modelBuilder.Entity("ProjectAngular.Models.District", b =>
                {
                    b.HasOne("ProjectAngular.Models.Division", "Division")
                        .WithMany("Districts")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");
                });

            modelBuilder.Entity("ProjectAngular.Models.EducationalInfo", b =>
                {
                    b.HasOne("ProjectAngular.Models.PersonalInfo", "PersonalInfo")
                        .WithMany("EducationalInfo")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("ProjectAngular.Models.EmploymentInfo", b =>
                {
                    b.HasOne("ProjectAngular.Models.Department", null)
                        .WithMany("EmploymentInfos")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAngular.Models.PersonalInfo", "PersonalInfo")
                        .WithOne("EmploymentInfo")
                        .HasForeignKey("ProjectAngular.Models.EmploymentInfo", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("ProjectAngular.Models.PersonalInfo", b =>
                {
                    b.HasOne("ProjectAngular.Models.District", "District")
                        .WithMany("PersonalInfos")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("ProjectAngular.Models.Department", b =>
                {
                    b.Navigation("EmploymentInfos");
                });

            modelBuilder.Entity("ProjectAngular.Models.District", b =>
                {
                    b.Navigation("PersonalInfos");
                });

            modelBuilder.Entity("ProjectAngular.Models.Division", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("ProjectAngular.Models.PersonalInfo", b =>
                {
                    b.Navigation("EducationalInfo");

                    b.Navigation("EmploymentInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
