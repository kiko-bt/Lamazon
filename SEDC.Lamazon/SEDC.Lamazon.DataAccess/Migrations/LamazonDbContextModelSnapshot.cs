﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.Lamazon.DataAccess;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    [DbContext(typeof(LamazonDbContext))]
    partial class LamazonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfOrder = new DateTime(2021, 2, 25, 18, 37, 20, 279, DateTimeKind.Local).AddTicks(260),
                            IsPaid = false,
                            Status = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfOrder = new DateTime(2021, 2, 25, 18, 37, 20, 280, DateTimeKind.Local).AddTicks(7998),
                            IsPaid = false,
                            Status = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfOrder = new DateTime(2021, 2, 25, 18, 37, 20, 280, DateTimeKind.Local).AddTicks(8031),
                            IsPaid = false,
                            Status = 2,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 2,
                            Description = "The best samsung phone on the market",
                            Name = "Samsung Galaxy S20",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            Category = 4,
                            Description = "Full bag of ice for your party",
                            Name = "Ice",
                            Price = 2.0
                        },
                        new
                        {
                            Id = 3,
                            Category = 1,
                            Description = "Scotch wiskey",
                            Name = "Johnnie Walker",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 4,
                            Category = 3,
                            Description = "The last book of Harry Potter",
                            Name = "Harry Potter",
                            Price = 15.0
                        });
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductOrders");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            OrderId = 1,
                            Id = 1
                        },
                        new
                        {
                            ProductId = 3,
                            OrderId = 2,
                            Id = 2
                        },
                        new
                        {
                            ProductId = 2,
                            OrderId = 3,
                            Id = 3
                        },
                        new
                        {
                            ProductId = 1,
                            OrderId = 3,
                            Id = 4
                        });
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Supplier"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Slavko Lumbarkovski 16",
                            Age = 26,
                            FirstName = "Hristijan",
                            LastName = "Petrovski",
                            Password = "kiko12345",
                            RoleId = 2,
                            Username = "ChrisP"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Partizanska 39",
                            Age = 27,
                            FirstName = "Mario",
                            LastName = "Zdravkovski",
                            Password = "marioBt",
                            RoleId = 2,
                            Username = "MarioZ"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Bela Cesma 10",
                            Age = 29,
                            FirstName = "Petar",
                            LastName = "Todorovski",
                            Password = "peroVoVero",
                            RoleId = 2,
                            Username = "Peckata"
                        });
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Order", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEDC.Lamazon.Domain.Models.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.User", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
