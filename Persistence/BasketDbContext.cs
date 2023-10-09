using System;
using assignment9.Entities;
using Microsoft.EntityFrameworkCore;

namespace assignment9.Persistence
{
	public class BasketDbContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }

		public DbSet<Order> Orders { get; set; }

		public BasketDbContext()
		{
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Basket");
        }
    }
}

