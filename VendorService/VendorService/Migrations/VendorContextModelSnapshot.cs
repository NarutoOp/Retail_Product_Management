﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendorService.Data;

namespace VendorService.Migrations
{
    [DbContext(typeof(VendorContext))]
    partial class VendorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VendorService.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DeliveryCharge")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Vendor");

                    b.HasData(
                        new
                        {
                            Id = 201,
                            DeliveryCharge = 45.0,
                            Name = "DelhiMotoShop",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 202,
                            DeliveryCharge = 50.0,
                            Name = "HydMotoShop",
                            Rating = 4.0
                        });
                });

            modelBuilder.Entity("VendorService.Models.VendorStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HandInStocks")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReplinshmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("VendorStock");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HandInStocks = 24,
                            ProductId = 101,
                            ReplinshmentDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VendorId = 201
                        },
                        new
                        {
                            Id = 2,
                            HandInStocks = 24,
                            ProductId = 1,
                            ReplinshmentDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VendorId = 201
                        });
                });

            modelBuilder.Entity("VendorService.Models.VendorStock", b =>
                {
                    b.HasOne("VendorService.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendor");
                });
#pragma warning restore 612, 618
        }
    }
}
