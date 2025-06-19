using AspApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AspApi.Data
{
    public static class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Define user IDs
            var adminUserId = "a1b2c3d4-e5f6-7890-abcd-ef1234567890";
            var regularUserId = "b2c3d4e5-f6a1-8907-bcda-fe2345678901";

            // Initialize the password hasher
            var hasher = new PasswordHasher<User>();

            // Create admin user
            var adminUser = new User
            {
                Id = "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                UserName = "admin@site.com",
                NormalizedUserName = "ADMIN@SITE.COM",
                Email = "admin@site.com",
                NormalizedEmail = "ADMIN@SITE.COM",
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                PasswordHash= string.Empty,
            };
            //adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin123!");

            // Create regular user
            var regularUser = new User
            {
                Id = "b2c3d4e5-f6a1-8907-bcda-fe2345678901",
                UserName = "user@site.com",
                NormalizedUserName = "USER@SITE.COM",
                Email = "user@site.com",
                NormalizedEmail = "USER@SITE.COM",
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                PasswordHash= string.Empty,
               
            };
            //regularUser.PasswordHash=hasher.HashPassword(regularUser, "Password");
            // Seed users
            modelBuilder.Entity<User>().HasData(adminUser, regularUser);

            // Seed user roles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                    RoleId = "1" // Admin
                },
                new IdentityUserRole<string>
                {
                    UserId = "b2c3d4e5-f6a1-8907-bcda-fe2345678901",
                    RoleId = "2" // User
                }
            );
        }
    }
}