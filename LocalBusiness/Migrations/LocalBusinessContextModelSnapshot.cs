﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    partial class LocalBusinessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LocalBusiness.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Location")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 2,
                            Description = "Classic American",
                            Location = "Belltown",
                            Name = "El Gacho",
                            Rating = 9,
                            Review = "Excellent",
                            Type = "Restaurant"
                        },
                        new
                        {
                            BusinessId = 3,
                            Description = "Modern Japanese",
                            Location = "Downtown",
                            Name = "Japonessa",
                            Rating = 7,
                            Review = "Great",
                            Type = "Restaurant"
                        },
                        new
                        {
                            BusinessId = 4,
                            Description = "Mexican",
                            Location = "Fremont",
                            Name = "Red Star Tacos",
                            Rating = 5,
                            Review = "Mediocre",
                            Type = "Restaurant"
                        },
                        new
                        {
                            BusinessId = 5,
                            Description = "Fresh produces",
                            Location = "White center",
                            Name = "Juan Garden",
                            Rating = 8,
                            Review = "Excellent",
                            Type = "Local Produce"
                        },
                        new
                        {
                            BusinessId = 6,
                            Description = "Plant Shop ",
                            Location = "White Center",
                            Name = "The Plant Store",
                            Rating = 8,
                            Review = "Excellent",
                            Type = "Local Shop"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
