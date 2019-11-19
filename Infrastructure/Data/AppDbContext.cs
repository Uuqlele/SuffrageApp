using Core.Entities;
using Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<IdentityAppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Poll> Polls { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Answer> Answers { get; set; }
        //public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Poll>()
              .HasMany(poll => poll.Options)
              .WithOne(option => option.Poll)
              .OnDelete(DeleteBehavior.Cascade);
              

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            int result = base.SaveChanges();

            return result;
        }
    }
}
