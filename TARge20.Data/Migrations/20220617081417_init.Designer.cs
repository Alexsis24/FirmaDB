﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20220617081417_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhooneNR")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Children", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Childrens");
                });

            modelBuilder.Entity("TARge20.Core.Domain.ClearanceLV", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ClearanceLVs");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhooneNR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistryID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid?>("ChildrenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClearanceLVId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MedicalRecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProfessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RentalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("VacationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChildrenId");

                    b.HasIndex("ClearanceLVId");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("RentalId");

                    b.HasIndex("VacationId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Equiptment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RentalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RentalId");

                    b.ToTable("Equiptments");
                });

            modelBuilder.Entity("TARge20.Core.Domain.MedicalRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("TARge20.Core.Domain.PermissionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClearanceLVId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClearanceLVId");

                    b.ToTable("PermissionTypes");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Profession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Rental", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SickLeave", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MedicalRecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("SickLeaves");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Branch", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Company", null)
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TARge20.Core.Domain.Employee", null)
                        .WithMany("Branches")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Children", null)
                        .WithMany("Employees")
                        .HasForeignKey("ChildrenId");

                    b.HasOne("TARge20.Core.Domain.ClearanceLV", null)
                        .WithMany("Employees")
                        .HasForeignKey("ClearanceLVId");

                    b.HasOne("TARge20.Core.Domain.MedicalRecord", null)
                        .WithMany("Employees")
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("TARge20.Core.Domain.Profession", null)
                        .WithMany("Employees")
                        .HasForeignKey("ProfessionId");

                    b.HasOne("TARge20.Core.Domain.Rental", null)
                        .WithMany("Employees")
                        .HasForeignKey("RentalId");

                    b.HasOne("TARge20.Core.Domain.Vacation", null)
                        .WithMany("Employees")
                        .HasForeignKey("VacationId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Equiptment", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Rental", null)
                        .WithMany("Equiptments")
                        .HasForeignKey("RentalId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.PermissionType", b =>
                {
                    b.HasOne("TARge20.Core.Domain.ClearanceLV", null)
                        .WithMany("PermissionTypes")
                        .HasForeignKey("ClearanceLVId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Profession", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Branch", null)
                        .WithMany("Professions")
                        .HasForeignKey("BranchId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SickLeave", b =>
                {
                    b.HasOne("TARge20.Core.Domain.MedicalRecord", null)
                        .WithMany("SickLeaves")
                        .HasForeignKey("MedicalRecordId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Branch", b =>
                {
                    b.Navigation("Professions");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Children", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("TARge20.Core.Domain.ClearanceLV", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("PermissionTypes");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("TARge20.Core.Domain.MedicalRecord", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("SickLeaves");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Profession", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Rental", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Equiptments");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacation", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
