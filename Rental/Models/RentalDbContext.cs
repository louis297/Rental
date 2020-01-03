﻿using System;
using Microsoft.EntityFrameworkCore;
using Rental.Models.ItemModels;

namespace Rental.Models
{
    public class RentalDbContext: DbContext
    {
        public DbSet<Item> items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: move connect string to config file
            optionsBuilder.UseMySQL("Server=localhost;Database=Rental;user=root;password=sqL3345!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ItemID=1,
                    Title="item1",
                    Detail="details1",
                    ExpireTime=DateTime.Parse("2020-06-01 00:00:00"),
                    Price=200
                },
                new Item
                {
                    ItemID = 2,
                    Title = "item2",
                    Detail = "details2",
                    ExpireTime = DateTime.Parse("2020-07-01 06:00:00"),
                    Price = 100
                }
            );
        }
    }
}
