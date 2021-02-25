using Microsoft.EntityFrameworkCore;
using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Domain.Models;
using System;

namespace SEDC.Lamazon.DataAccess
{
    public class LamazonDbContext : DbContext
    {
        public LamazonDbContext(DbContextOptions options)
            :base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }



        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                        .HasData(
                        new Role
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new Role
                        {
                            Id = 2,
                            Name = "Supplier"
                        },
                        new Role
                        {
                            Id = 3,
                            Name = "Customer"
                        });



            modelBuilder.Entity<User>()
            .HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Hristijan",
                    LastName = "Petrovski",
                    Username = "ChrisP",
                    Password = "kiko12345",
                    Address = "Slavko Lumbarkovski 16",
                    Age = 26,
                    RoleId = 2
                },
                new User
                {
                    Id = 2,
                    FirstName = "Mario",
                    LastName = "Zdravkovski",
                    Username = "MarioZ",
                    Password = "marioBt",
                    Address = "Partizanska 39",
                    Age = 27,
                    RoleId = 2
                },
                new User
                {
                    Id = 3,
                    FirstName = "Petar",
                    LastName = "Todorovski",
                    Username = "Peckata",
                    Password = "peroVoVero",
                    Address = "Bela Cesma 10",
                    Age = 29,
                    RoleId = 2
                });



            modelBuilder.Entity<Order>()
            .HasData(
                new Order
                {
                    Id = 1,
                    Status = StatusType.Init,
                    IsPaid = false,
                    DateOfOrder = DateTime.Now,
                    UserId = 1
                },
                new Order
                {
                    Id = 2,
                    Status = StatusType.Pending,
                    IsPaid = false,
                    DateOfOrder = DateTime.Now,
                    UserId = 2
                },
                new Order
                {
                    Id = 3,
                    Status = StatusType.Confirmed,
                    IsPaid = false,
                    DateOfOrder = DateTime.Now,
                    UserId = 3
                });



            modelBuilder.Entity<Product>()
                        .HasData(
                        new Product
                        {
                            Id = 1,
                            Name = "Samsung Galaxy S20",
                            Price = 1000,
                            Description = "The best samsung phone on the market",
                            Category = CategoryType.Electronics
                        },
                        new Product
                        {
                            Id = 2,
                            Name = "Ice",
                            Price = 2,
                            Description = "Full bag of ice for your party",
                            Category = CategoryType.Other
                        },
                        new Product
                        {
                            Id = 3,
                            Name = "Johnnie Walker",
                            Price = 30,
                            Description = "Scotch wiskey",
                            Category = CategoryType.Drinks
                        },
                        new Product
                        {
                            Id = 4,
                            Name = "Harry Potter",
                            Price = 15,
                            Description = "The last book of Harry Potter",
                            Category = CategoryType.Books
                        });

            modelBuilder.Entity<ProductOrder>()
                        .HasData(
                        new ProductOrder
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 1
                        },
                        new ProductOrder
                        {
                            Id = 2,
                            OrderId = 2,
                            ProductId = 3
                        },
                        new ProductOrder
                        {
                            Id = 3,
                            OrderId = 3,
                            ProductId = 2
                        },
                        new ProductOrder
                        {
                            Id = 4,
                            OrderId = 3,
                            ProductId = 1
                        });     
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductOrder>()
                        .HasKey(po => new { po.ProductId, po.OrderId });


            modelBuilder.Entity<User>()
                        .HasMany(u => u.Orders)
                        .WithOne(u => u.User)
                        .HasForeignKey(u => u.UserId);


            modelBuilder.Entity<Order>()
                        .HasMany(o => o.ProductOrders)
                        .WithOne(po => po.Order)
                        .HasForeignKey(po => po.OrderId);


            modelBuilder.Entity<Product>()
                        .HasMany(p => p.ProductOrders)
                        .WithOne(p => p.Product)
                        .HasForeignKey(p => p.ProductId);


            modelBuilder.Entity<Role>()
                        .HasMany(r => r.Users)
                        .WithOne(u => u.Role)
                        .HasForeignKey(u => u.RoleId);




            Seed(modelBuilder);
        }
    }
}
