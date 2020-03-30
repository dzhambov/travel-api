﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    [Migration("20200330163808_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Rating");

                    b.HasKey("DestinationId");

                    b.ToTable("Destination");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "New York City",
                            Country = "United States",
                            Rating = 7
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "London",
                            Country = "England",
                            Rating = 10
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Toronto",
                            Country = "Canada",
                            Rating = 2
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "Guangzho",
                            Country = "China",
                            Rating = 4
                        },
                        new
                        {
                            DestinationId = 5,
                            City = "Belfast",
                            Country = "Northern Ireland",
                            Rating = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
