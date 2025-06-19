using System;
using AspApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspApi.Data
{
    
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        public ApplicationDBContext(Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<AspApi.Models.Stock> Stocks { get; set; } = null!;
        public DbSet<AspApi.Models.Comment> Comments { get; set; } = null!;
        public DbSet<AspApi.Models.Portfolio> Portfolios { get; set; } = null!;


        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            StockSeeder.Seed(modelBuilder);
            CommentSeeder.Seed(modelBuilder);
            //UserSeeder.Seed(modelBuilder);
            modelBuilder.Entity<Portfolio>(x =>
            {
                x.HasKey(p => new { p.UserId, p.StockId });

                
                x.HasOne(p => p.User)
                 .WithMany(u => u.Portfolios)
                 .HasForeignKey(p => p.UserId);

                x.HasOne(p => p.Stock)
                 .WithMany(s => s.Portfolios)
                 .HasForeignKey(p => p.StockId);
            });
             var hasher = new PasswordHasher<User>();
            List<IdentityRole> roles=new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "User",
                    NormalizedName = "USER"
                }
            };
         
            modelBuilder.Entity<IdentityRole>().HasData(roles);
             var users =new User
                {
                    UserName = "Admin",
                    Email = "admin@gmail",
                    PasswordHash= "AQAAAAIAAYagAAAAEFiuApPrUJFi+6C+jcFSnd4hOo1Vqnl4p04g/zfCFP9SOFHeKfOAxqWZhAquYCOgaw=="
                };
            //modelBuilder.Entity<User>().HasData(users);


            modelBuilder.Entity<AspApi.Models.Stock>().ToTable("Stocks");
            modelBuilder.Entity<AspApi.Models.Comment>().ToTable("Comments");
            
        }
    }
}