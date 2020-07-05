﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(GarageContext))]
    [Migration("20200705131556_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Model.GatekeeperLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Direction")
                        .HasColumnType("tinyint");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<DateTime>("PassOver")
                        .HasColumnType("datetime2");

                    b.Property<string>("VehicleColor")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("GatekeeperLogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direction = (byte)1,
                            LicensePlate = "ABC123",
                            PassOver = new DateTime(2020, 6, 26, 10, 10, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Yellow"
                        },
                        new
                        {
                            Id = 2,
                            Direction = (byte)1,
                            LicensePlate = "ABC124",
                            PassOver = new DateTime(2020, 6, 26, 10, 15, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Red"
                        },
                        new
                        {
                            Id = 3,
                            Direction = (byte)1,
                            LicensePlate = "ABC125",
                            PassOver = new DateTime(2020, 6, 26, 10, 30, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Blue"
                        },
                        new
                        {
                            Id = 4,
                            Direction = (byte)1,
                            LicensePlate = "ABC126",
                            PassOver = new DateTime(2020, 6, 26, 10, 35, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Purple"
                        },
                        new
                        {
                            Id = 5,
                            Direction = (byte)1,
                            LicensePlate = "ABC127",
                            PassOver = new DateTime(2020, 6, 26, 10, 55, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Black"
                        },
                        new
                        {
                            Id = 6,
                            Direction = (byte)1,
                            LicensePlate = "ABC128",
                            PassOver = new DateTime(2020, 6, 26, 11, 15, 0, 0, DateTimeKind.Local),
                            VehicleColor = "White"
                        },
                        new
                        {
                            Id = 7,
                            Direction = (byte)2,
                            LicensePlate = "ABC123",
                            PassOver = new DateTime(2020, 6, 26, 11, 25, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Orange"
                        },
                        new
                        {
                            Id = 8,
                            Direction = (byte)1,
                            LicensePlate = "ABC129",
                            PassOver = new DateTime(2020, 6, 26, 11, 45, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Green"
                        },
                        new
                        {
                            Id = 9,
                            Direction = (byte)2,
                            LicensePlate = "ABC124",
                            PassOver = new DateTime(2020, 6, 26, 12, 10, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Red"
                        },
                        new
                        {
                            Id = 10,
                            Direction = (byte)2,
                            LicensePlate = "ABC125",
                            PassOver = new DateTime(2020, 6, 26, 13, 20, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Blue"
                        },
                        new
                        {
                            Id = 11,
                            Direction = (byte)2,
                            LicensePlate = "ABC126",
                            PassOver = new DateTime(2020, 6, 26, 14, 30, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Purple"
                        },
                        new
                        {
                            Id = 12,
                            Direction = (byte)2,
                            LicensePlate = "ABC127",
                            PassOver = new DateTime(2020, 6, 26, 15, 45, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Black"
                        },
                        new
                        {
                            Id = 13,
                            Direction = (byte)2,
                            LicensePlate = "ABC128",
                            PassOver = new DateTime(2020, 6, 26, 16, 50, 0, 0, DateTimeKind.Local),
                            VehicleColor = "White"
                        },
                        new
                        {
                            Id = 14,
                            Direction = (byte)2,
                            LicensePlate = "ABC129",
                            PassOver = new DateTime(2020, 6, 26, 17, 55, 0, 0, DateTimeKind.Local),
                            VehicleColor = "Green"
                        },
                        new
                        {
                            Id = 25,
                            Direction = (byte)1,
                            LicensePlate = "ABC123",
                            PassOver = new DateTime(2020, 6, 27, 7, 40, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 26,
                            Direction = (byte)1,
                            LicensePlate = "ABC124",
                            PassOver = new DateTime(2020, 6, 27, 8, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 27,
                            Direction = (byte)1,
                            LicensePlate = "ABC125",
                            PassOver = new DateTime(2020, 6, 27, 8, 30, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 28,
                            Direction = (byte)1,
                            LicensePlate = "ABC126",
                            PassOver = new DateTime(2020, 6, 27, 8, 35, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 29,
                            Direction = (byte)1,
                            LicensePlate = "ABC127",
                            PassOver = new DateTime(2020, 6, 27, 8, 40, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 30,
                            Direction = (byte)1,
                            LicensePlate = "ABC128",
                            PassOver = new DateTime(2020, 6, 27, 9, 15, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 31,
                            Direction = (byte)1,
                            LicensePlate = "ABC129",
                            PassOver = new DateTime(2020, 6, 27, 9, 55, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 32,
                            Direction = (byte)2,
                            LicensePlate = "ABC123",
                            PassOver = new DateTime(2020, 6, 27, 16, 30, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 33,
                            Direction = (byte)2,
                            LicensePlate = "ABC124",
                            PassOver = new DateTime(2020, 6, 27, 17, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 34,
                            Direction = (byte)2,
                            LicensePlate = "ABC125",
                            PassOver = new DateTime(2020, 6, 27, 17, 15, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 35,
                            Direction = (byte)2,
                            LicensePlate = "ABC126",
                            PassOver = new DateTime(2020, 6, 27, 17, 20, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 36,
                            Direction = (byte)2,
                            LicensePlate = "ABC127",
                            PassOver = new DateTime(2020, 6, 27, 18, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 37,
                            Direction = (byte)2,
                            LicensePlate = "ABC128",
                            PassOver = new DateTime(2020, 6, 27, 18, 50, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 38,
                            Direction = (byte)2,
                            LicensePlate = "ABC129",
                            PassOver = new DateTime(2020, 6, 27, 19, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 39,
                            Direction = (byte)1,
                            LicensePlate = "ABC123",
                            PassOver = new DateTime(2020, 6, 27, 20, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 40,
                            Direction = (byte)1,
                            LicensePlate = "ABC124",
                            PassOver = new DateTime(2020, 6, 28, 7, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 41,
                            Direction = (byte)1,
                            LicensePlate = "ABC125",
                            PassOver = new DateTime(2020, 6, 28, 7, 35, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 42,
                            Direction = (byte)1,
                            LicensePlate = "ABC126",
                            PassOver = new DateTime(2020, 6, 28, 7, 45, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 43,
                            Direction = (byte)1,
                            LicensePlate = "ABC127",
                            PassOver = new DateTime(2020, 6, 28, 8, 15, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 44,
                            Direction = (byte)1,
                            LicensePlate = "ABC128",
                            PassOver = new DateTime(2020, 6, 28, 9, 25, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 45,
                            Direction = (byte)1,
                            LicensePlate = "ABC129",
                            PassOver = new DateTime(2020, 6, 28, 10, 35, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 46,
                            Direction = (byte)2,
                            LicensePlate = "ABC123",
                            PassOver = new DateTime(2020, 6, 28, 16, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 47,
                            Direction = (byte)2,
                            LicensePlate = "ABC124",
                            PassOver = new DateTime(2020, 6, 28, 17, 10, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 48,
                            Direction = (byte)2,
                            LicensePlate = "ABC125",
                            PassOver = new DateTime(2020, 6, 28, 18, 15, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 49,
                            Direction = (byte)2,
                            LicensePlate = "ABC126",
                            PassOver = new DateTime(2020, 6, 28, 19, 20, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 50,
                            Direction = (byte)2,
                            LicensePlate = "ABC127",
                            PassOver = new DateTime(2020, 6, 28, 20, 25, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 51,
                            Direction = (byte)2,
                            LicensePlate = "ABC128",
                            PassOver = new DateTime(2020, 6, 28, 21, 30, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("Data.Model.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Begin")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(5,2)")
                        .HasDefaultValue(0.0m);

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte>("PaymentPeriod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)1);

                    b.HasKey("Id");

                    b.ToTable("Partner");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Begin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0.1m,
                            Name = "Partner1",
                            PaymentPeriod = (byte)1
                        },
                        new
                        {
                            Id = 2,
                            Begin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0.0m,
                            Name = "Partner2",
                            PaymentPeriod = (byte)2
                        },
                        new
                        {
                            Id = 3,
                            Begin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Discount = 0.15m,
                            Name = "Partner3",
                            PaymentPeriod = (byte)3
                        },
                        new
                        {
                            Id = 4,
                            Begin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardId = 11111,
                            Discount = 0.3m,
                            Name = "Partner4",
                            PaymentPeriod = (byte)3
                        },
                        new
                        {
                            Id = 5,
                            Begin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardId = 22222,
                            Discount = 0.3m,
                            Name = "Partner5",
                            PaymentPeriod = (byte)3
                        });
                });

            modelBuilder.Entity("Data.Model.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LicensePlate")
                        .IsUnique();

                    b.HasIndex("PartnerId");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LicensePlate = "ABC123",
                            PartnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            LicensePlate = "ABC124",
                            PartnerId = 2
                        },
                        new
                        {
                            Id = 3,
                            LicensePlate = "ABC125",
                            PartnerId = 3
                        },
                        new
                        {
                            Id = 4,
                            LicensePlate = "ABC126",
                            PartnerId = 4
                        },
                        new
                        {
                            Id = 5,
                            LicensePlate = "ABC127",
                            PartnerId = 4
                        },
                        new
                        {
                            Id = 6,
                            LicensePlate = "ABC128",
                            PartnerId = 5
                        },
                        new
                        {
                            Id = 7,
                            LicensePlate = "ABC129",
                            PartnerId = 5
                        });
                });

            modelBuilder.Entity("Data.Model.Vehicle", b =>
                {
                    b.HasOne("Data.Model.Partner", "Partner")
                        .WithMany("Vehicles")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
