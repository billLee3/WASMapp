﻿// <auto-generated />
using System;
using CRUDBlazorApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDBlazorApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUDBlazorApp.Shared.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Electricity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelOil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NaturalGas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POCName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POCPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POCRelationToProp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalSetting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("Propane")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeSqFt")
                        .HasColumnType("int");

                    b.Property<string>("Weather")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zoning")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Forms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Electricity = "yes",
                            FuelOil = "yes",
                            NaturalGas = "yes",
                            POCName = "Test",
                            POCPhone = "123-456-7890",
                            POCRelationToProp = "Test",
                            PhysicalSetting = "urban",
                            ProjectID = 1,
                            Propane = "yes",
                            SizeSqFt = 1000,
                            Weather = "sunny",
                            Zoning = "residential"
                        },
                        new
                        {
                            Id = 2,
                            Electricity = "yes",
                            FuelOil = "yes",
                            NaturalGas = "yes",
                            POCName = "Test",
                            POCPhone = "123-456-7890",
                            POCRelationToProp = "Test",
                            PhysicalSetting = "urban",
                            ProjectID = 1,
                            Propane = "yes",
                            SizeSqFt = 1000,
                            Weather = "sunny",
                            Zoning = "residential"
                        });
                });

            modelBuilder.Entity("CRUDBlazorApp.Shared.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressName = "1",
                            AssignedTo = "Test",
                            City = "1",
                            CreateDate = new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3898),
                            CreatedBy = "Test",
                            LastUpdate = new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3902),
                            LastUpdatedBy = "Test",
                            Name = "Project 1",
                            State = "1",
                            Status = "Open",
                            Type = ""
                        },
                        new
                        {
                            Id = 2,
                            AddressName = "Columbus Ave",
                            AssignedTo = "Test",
                            City = "Huntsville",
                            CreateDate = new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3904),
                            CreatedBy = "Test",
                            LastUpdate = new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3904),
                            LastUpdatedBy = "Test",
                            Name = "Project 2",
                            State = "AL",
                            Status = "Open",
                            Type = ""
                        },
                        new
                        {
                            Id = 3,
                            AddressName = "Huntsvill Road",
                            AssignedTo = "Test",
                            City = "Columbus",
                            CreateDate = new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3905),
                            CreatedBy = "Test",
                            LastUpdate = new DateTime(2023, 8, 29, 1, 14, 56, 23, DateTimeKind.Utc).AddTicks(3906),
                            LastUpdatedBy = "Test",
                            Name = "Project 3",
                            State = "OH",
                            Status = "Open",
                            Type = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}