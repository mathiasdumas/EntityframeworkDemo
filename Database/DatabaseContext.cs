using System;
using EntityTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityTest.Database
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Animal> Animals { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Reservation> Reservations { get; set; }

		static readonly string connectionString = "server=localhost;port=3306;database=testEntity;user=root;password=root;";

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
		}
	}
}

