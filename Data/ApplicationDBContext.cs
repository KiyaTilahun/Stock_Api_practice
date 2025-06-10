using System;
using Microsoft.EntityFrameworkCore;

namespace AspApi.Data
{
    
    public class ApplicationDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDBContext(Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<AspApi.Models.Stock> Stocks { get; set; } = null!;
        public DbSet<AspApi.Models.Comment> Comments { get; set; } = null!;


        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AspApi.Models.Stock>().ToTable("Stocks");
            modelBuilder.Entity<AspApi.Models.Comment>().ToTable("Comments");
        }
    }
}