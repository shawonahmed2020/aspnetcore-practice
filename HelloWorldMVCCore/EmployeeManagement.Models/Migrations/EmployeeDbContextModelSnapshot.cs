﻿
using System;

using EmployeeManagement.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Models.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.EntityModels.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);


                    b.Property<int?>("EmployeeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

    b.HasIndex("EmployeeId");


                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeManagement.Models.EntityModels.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("RegNo");

                    b.Property<double>("Salary");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagement.Models.EntityModels.Department", b =>
                {
                    b.HasOne("EmployeeManagement.Models.EntityModels.Employee", "Employee")
                        .WithMany("Departments")
                        .HasForeignKey("EmployeeId");
                });

#pragma warning restore 612, 618
        }
    }
}
