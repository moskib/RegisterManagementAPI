﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RegisterManagement.Data;

namespace RegisterManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RegisterManagement.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 500,
                            DateCreated = new DateTime(2020, 1, 12, 12, 2, 47, 406, DateTimeKind.Local).AddTicks(5272),
                            DateModified = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9051),
                            ItemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 200,
                            DateCreated = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9617),
                            DateModified = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9635),
                            ItemId = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 700,
                            DateCreated = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9649),
                            DateModified = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9652),
                            ItemId = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount = 1000,
                            DateCreated = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9655),
                            DateModified = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9657),
                            ItemId = 4
                        },
                        new
                        {
                            Id = 5,
                            Amount = 1234,
                            DateCreated = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9660),
                            DateModified = new DateTime(2020, 1, 12, 12, 2, 47, 408, DateTimeKind.Local).AddTicks(9663),
                            ItemId = 5
                        });
                });

            modelBuilder.Entity("RegisterManagement.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsRefundable")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 15.99,
                            IsRefundable = true,
                            Name = "T-Shirt"
                        },
                        new
                        {
                            Id = 2,
                            Cost = 5.9900000000000002,
                            IsRefundable = false,
                            Name = "Underwear"
                        },
                        new
                        {
                            Id = 3,
                            Cost = 60.990000000000002,
                            IsRefundable = true,
                            Name = "Denim jeans"
                        },
                        new
                        {
                            Id = 4,
                            Cost = 99.989999999999995,
                            IsRefundable = true,
                            Name = "Coat"
                        },
                        new
                        {
                            Id = 5,
                            Cost = 19.989999999999998,
                            IsRefundable = true,
                            Name = "Sweater"
                        });
                });

            modelBuilder.Entity("RegisterManagement.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfPurchase")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("VisaNo")
                        .HasColumnType("text");

                    b.HasKey("PurchaseNo");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("RegisterManagement.Models.PurchaseItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("PurchaseItems");
                });

            modelBuilder.Entity("RegisterManagement.Models.Inventory", b =>
                {
                    b.HasOne("RegisterManagement.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegisterManagement.Models.PurchaseItem", b =>
                {
                    b.HasOne("RegisterManagement.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegisterManagement.Models.Purchase", "Purchase")
                        .WithMany("PurchaseItems")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
