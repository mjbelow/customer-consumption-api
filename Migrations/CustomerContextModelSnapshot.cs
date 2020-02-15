﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using customer_consumption_api.Data;

namespace customer_consumption_api.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("customer_consumption_api.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("customer_consumption_api.Models.CustomerLocation", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountLocationKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ServiceEnd")
                        .HasColumnType("Date");

                    b.Property<DateTime>("ServiceStart")
                        .HasColumnType("Date");

                    b.HasKey("CustomerId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("CustomerLocations");
                });

            modelBuilder.Entity("customer_consumption_api.Models.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("customer_consumption_api.Models.Meter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Channel1FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel1Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel1RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel2FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel2Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel2RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel3FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel3Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel3RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel4FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel4Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel4RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel5FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel5Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel5RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel6FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel6Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel6RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel7FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel7Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel7RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel8FinalUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel8Multiplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel8RawUom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IntervalLength")
                        .HasColumnType("int");

                    b.Property<string>("MeterCycle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeterType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meters");
                });

            modelBuilder.Entity("customer_consumption_api.Models.MeterInterval", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChannelId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Read15Min")
                        .HasColumnType("int");

                    b.Property<int>("Read30Min")
                        .HasColumnType("int");

                    b.Property<int>("Read5Min")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReadDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("ReadDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReadHour")
                        .HasColumnType("int");

                    b.Property<decimal>("ReadValue")
                        .HasColumnType("decimal(7,4)");

                    b.Property<string>("Uom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MeterId");

                    b.ToTable("MeterIntervals");
                });

            modelBuilder.Entity("customer_consumption_api.Models.MeterLocation", b =>
                {
                    b.Property<string>("MeterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ActiveDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("InactiveDate")
                        .HasColumnType("Date");

                    b.HasKey("MeterId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("MeterLocations");
                });

            modelBuilder.Entity("customer_consumption_api.Models.CustomerLocation", b =>
                {
                    b.HasOne("customer_consumption_api.Models.Customer", "Customer")
                        .WithMany("CustomerLocations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("customer_consumption_api.Models.Location", "Location")
                        .WithMany("CustomerLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("customer_consumption_api.Models.MeterInterval", b =>
                {
                    b.HasOne("customer_consumption_api.Models.Meter", "Meter")
                        .WithMany("MeterIntervals")
                        .HasForeignKey("MeterId");
                });

            modelBuilder.Entity("customer_consumption_api.Models.MeterLocation", b =>
                {
                    b.HasOne("customer_consumption_api.Models.Location", "Location")
                        .WithMany("MeterLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("customer_consumption_api.Models.Meter", "Meter")
                        .WithMany("MeterLocations")
                        .HasForeignKey("MeterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
