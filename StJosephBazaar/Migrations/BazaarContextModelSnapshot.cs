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
#pragma warning restore 612, 618
        }
    }
}