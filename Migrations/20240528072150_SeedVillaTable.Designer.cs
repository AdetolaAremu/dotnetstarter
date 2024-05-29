﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dontnetstarter.DataStore;

#nullable disable

namespace dontnetstarter.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240528072150_SeedVillaTable")]
    partial class SeedVillaTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dontnetstarter.Models.VillaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageurl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("occupancy")
                        .HasColumnType("int");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.Property<int>("sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("villas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            amenity = "Pool, Ocean View, Wi-Fi",
                            created_at = new DateTime(2023, 11, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6210),
                            details = "A luxurious villa with ocean views and a private pool.",
                            imageurl = "https://example.com/images/luxury_villa.jpg",
                            name = "Luxury Villa",
                            occupancy = 8,
                            rate = 500.0,
                            sqft = 3000,
                            updated_at = new DateTime(2024, 5, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6230)
                        },
                        new
                        {
                            id = 2,
                            amenity = "Fireplace, Garden View, Wi-Fi",
                            created_at = new DateTime(2023, 9, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6240),
                            details = "A quaint cottage perfect for a romantic getaway.",
                            imageurl = "https://example.com/images/cozy_cottage.jpg",
                            name = "Cozy Cottage",
                            occupancy = 2,
                            rate = 150.0,
                            sqft = 800,
                            updated_at = new DateTime(2024, 5, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6240)
                        },
                        new
                        {
                            id = 3,
                            amenity = "Gym, City View, Wi-Fi",
                            created_at = new DateTime(2024, 2, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6250),
                            details = "A stylish apartment in the heart of the city.",
                            imageurl = "https://example.com/images/modern_apartment.jpg",
                            name = "Modern Apartment",
                            occupancy = 4,
                            rate = 200.0,
                            sqft = 1200,
                            updated_at = new DateTime(2024, 5, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6250)
                        },
                        new
                        {
                            id = 4,
                            amenity = "Hiking Trails, Fireplace, Wi-Fi",
                            created_at = new DateTime(2023, 5, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6250),
                            details = "A secluded cabin in the woods for a nature retreat.",
                            imageurl = "https://example.com/images/rustic_cabin.jpg",
                            name = "Rustic Cabin",
                            occupancy = 4,
                            rate = 180.0,
                            sqft = 1000,
                            updated_at = new DateTime(2024, 5, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6250)
                        },
                        new
                        {
                            id = 5,
                            amenity = "Beach Access, Ocean View, Wi-Fi",
                            created_at = new DateTime(2024, 1, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6250),
                            details = "A charming bungalow with direct beach access.",
                            imageurl = "https://example.com/images/beachfront_bungalow.jpg",
                            name = "Beachfront Bungalow",
                            occupancy = 6,
                            rate = 300.0,
                            sqft = 1500,
                            updated_at = new DateTime(2024, 5, 28, 8, 21, 50, 204, DateTimeKind.Local).AddTicks(6260)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}