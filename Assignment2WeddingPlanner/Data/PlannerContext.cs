using Assignment2WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Data
{
    public class PlannerContext : DbContext
    {
        public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
        {

        }

        public DbSet<UserEnquiry> UserEnquiries { get; set; }

        public DbSet<WeddingDetails> WeddingDetails { get; set; }

        public DbSet<WeddingPlanner> WeddingPlanners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEnquiry>().ToTable("UserEnquiry");

            modelBuilder.Entity<WeddingDetails>().ToTable("WeddingDetails");

            modelBuilder.Entity<WeddingPlanner>().ToTable("WeddingPlanner");
        }

    }
}
