using AspApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AspApi.Data;

public static class CommentSeeder
{
        public static void Seed(ModelBuilder modelBuilder)
        {
            var comments = new List<Comment>();

            for (int i = 1; i <= 30; i++)
            {
                comments.Add(new Comment
                {
                    Id = i,
                    Title = $"Comment Title {i}",
                    Content = $"This is the content for comment number {i}.",
                    CreatedOn = new DateTime(2023, 1, 15, 10, 30, 0).AddDays(i), // Vary the date
                    StockId = i // Link each comment to a unique stock
                });
            }

            modelBuilder.Entity<Comment>().HasData(comments);
        }
    }
