﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StJosephBazaar.Data;

#nullable disable

namespace StJosephBazaar.Migrations
{
    [DbContext(typeof(BazaarContext))]
    partial class BazaarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("StJosephBazaar.Models.Booth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("StartupTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Booth");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Startup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BoothName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Fives")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ones")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quarters")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tens")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.Property<int>("Twenties")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Startup");
                });
#pragma warning restore 612, 618
        }
    }
}
