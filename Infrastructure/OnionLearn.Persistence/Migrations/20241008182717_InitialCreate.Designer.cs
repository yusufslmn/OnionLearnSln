﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241008182717_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("OnionLearn.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 322, DateTimeKind.Local).AddTicks(3120),
                            IsDeleted = false,
                            Name = "Garden, Automotive & Music"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 322, DateTimeKind.Local).AddTicks(3130),
                            IsDeleted = false,
                            Name = "Outdoors"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 322, DateTimeKind.Local).AddTicks(3160),
                            IsDeleted = true,
                            Name = "Computers, Books & Automotive"
                        });
                });

            modelBuilder.Entity("OnionLearn.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAtDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 322, DateTimeKind.Local).AddTicks(4240),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 1,
                            Priorty = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 322, DateTimeKind.Local).AddTicks(4250),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 1,
                            Priorty = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 322, DateTimeKind.Local).AddTicks(4250),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 322, DateTimeKind.Local).AddTicks(4250),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 1,
                            Priorty = 2
                        });
                });

            modelBuilder.Entity("OnionLearn.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 323, DateTimeKind.Local).AddTicks(7700),
                            Description = "Voluptate at corrupti qui sint.",
                            IsDeleted = false,
                            Title = "Quaerat."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 323, DateTimeKind.Local).AddTicks(7730),
                            Description = "Sint facere qui distinctio est.",
                            IsDeleted = true,
                            Title = "Culpa."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 323, DateTimeKind.Local).AddTicks(7760),
                            Description = "A consequatur sit aut expedita.",
                            IsDeleted = false,
                            Title = "Recusandae."
                        });
                });

            modelBuilder.Entity("OnionLearn.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 325, DateTimeKind.Local).AddTicks(270),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Discount = 9.14588553864220m,
                            IsDeleted = false,
                            Price = 651.68m,
                            Title = "Incredible Fresh Shirt"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedAtDate = new DateTime(2024, 10, 8, 21, 27, 17, 325, DateTimeKind.Local).AddTicks(290),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Discount = 5.413175671154370m,
                            IsDeleted = false,
                            Price = 658.80m,
                            Title = "Rustic Granite Gloves"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("OnionLearn.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnionLearn.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnionLearn.Domain.Entities.Detail", b =>
                {
                    b.HasOne("OnionLearn.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OnionLearn.Domain.Entities.Product", b =>
                {
                    b.HasOne("OnionLearn.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("OnionLearn.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
