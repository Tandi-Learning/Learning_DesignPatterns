﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

#nullable disable

namespace Repository.Data.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20220817020113_CreateCompanySchema")]
    partial class CreateCompanySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Repository.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Household Head"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Household Finance"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Member"
                        });
                });

            modelBuilder.Entity("Repository.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Firstname = "Tandi",
                            Lastname = "Sunarto",
                            Level = 1
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Firstname = "Suyenti",
                            Lastname = "Sunarto",
                            Level = 1
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Firstname = "Scarlet",
                            Lastname = "Sunarto",
                            Level = 2
                        });
                });

            modelBuilder.Entity("Repository.Data.Entities.Employee", b =>
                {
                    b.HasOne("Repository.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
