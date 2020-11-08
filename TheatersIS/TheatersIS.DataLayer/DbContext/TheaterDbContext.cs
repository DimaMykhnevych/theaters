using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.DbContextN
{
    public class TheaterDbContext : DbContext
    {
        public TheaterDbContext(DbContextOptions dbContextOptions)
            :base(dbContextOptions)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theater>()
                .HasOne<Address>(s => s.Address)
                .WithOne(ad => ad.Theater)
                .HasForeignKey<Theater>(ad => ad.AddressId);
        }
        public DbSet<Theater> Theaters { get; set; }

        public DbSet<Performance> Performances { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<TheaterPerformance> TheaterPerformances { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<UserAnswer> UserAnswers { get; set; }

        public DbSet<Variant> Variants { get; set; }

        public DbSet<Question> Questions { get; set; }


    }
}
