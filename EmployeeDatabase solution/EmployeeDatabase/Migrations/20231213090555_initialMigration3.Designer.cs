﻿// <auto-generated />
using System;
using EmployeeDatabase.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeDatabase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231213090555_initialMigration3")]
    partial class initialMigration3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeDatabase.Models.Department", b =>
                {
                    b.Property<int>("DepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepId"));

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DepId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeDatabase.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProjID")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("deptID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("deptID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeDatabase.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("EmployeesID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsID")
                        .HasColumnType("int");

                    b.HasKey("EmployeesID", "ProjectsID");

                    b.HasIndex("ProjectsID");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("EmployeeDatabase.Models.Employee", b =>
                {
                    b.HasOne("EmployeeDatabase.Models.Department", "Departments")
                        .WithMany("Employees")
                        .HasForeignKey("deptID");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("EmployeeDatabase.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeDatabase.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeDatabase.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
