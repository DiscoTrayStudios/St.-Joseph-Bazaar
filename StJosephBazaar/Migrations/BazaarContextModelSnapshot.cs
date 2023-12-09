﻿// <auto-generated />
using System;
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

                    b.Property<decimal>("Auction")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Friday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Purchases")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Saturday")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("YearID");

                    b.ToTable("Booth");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Deposit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Checks")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Dimes")
                        .HasColumnType("REAL");

                    b.Property<int>("Fives")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Nickels")
                        .HasColumnType("REAL");

                    b.Property<int>("Ones")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Other_Change")
                        .HasColumnType("REAL");

                    b.Property<double>("Pennies")
                        .HasColumnType("REAL");

                    b.Property<double>("Quarters")
                        .HasColumnType("REAL");

                    b.Property<int>("Tens")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Twentys")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("YearID");

                    b.ToTable("Deposit");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Expense", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoothID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CheckNum")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("InvoiceNum")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.HasIndex("BoothID");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Income", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoothID")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("HourCollected")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecieptNum")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.HasIndex("BoothID");

                    b.ToTable("Income");
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

                    b.Property<int>("Twenties")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Startup");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Year", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Friday")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Saturday")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearVal")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Year");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Booth", b =>
                {
                    b.HasOne("StJosephBazaar.Models.Year", "Year")
                        .WithMany("Booths")
                        .HasForeignKey("YearID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Year");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Deposit", b =>
                {
                    b.HasOne("StJosephBazaar.Models.Year", "Year")
                        .WithMany()
                        .HasForeignKey("YearID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Year");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Expense", b =>
                {
                    b.HasOne("StJosephBazaar.Models.Booth", "Booth")
                        .WithMany("Expenses")
                        .HasForeignKey("BoothID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booth");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Income", b =>
                {
                    b.HasOne("StJosephBazaar.Models.Booth", "Booth")
                        .WithMany("Income")
                        .HasForeignKey("BoothID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booth");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Booth", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Income");
                });

            modelBuilder.Entity("StJosephBazaar.Models.Year", b =>
                {
                    b.Navigation("Booths");
                });
#pragma warning restore 612, 618
        }
    }
}
