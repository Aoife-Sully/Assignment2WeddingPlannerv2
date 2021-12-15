using Assignment2WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2WeddingPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserEnquiry> UserEnquiries { get; set; }

        public DbSet<WeddingDetails> WeddingDetails { get; set; }

        public DbSet<WeddingPlanner> WeddingPlanners { get; set; }


        //Ensures that the table names stay in the singular
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEnquiry>().ToTable("UserEnquiry");
            modelBuilder.Entity<WeddingDetails>().ToTable("WeddingDetails");
            modelBuilder.Entity<WeddingPlanner>().ToTable("WeddingPlanner");
        }


    }

}




