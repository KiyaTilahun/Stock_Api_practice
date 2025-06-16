using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using AspApi.Models;

namespace AspApi.Data
{
    public static class StockSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var stocks = new List<Stock>();

            for (int i = 1; i <= 30; i++)
            {
                stocks.Add(new Stock
                {
                    Id = i,
                    Symbol = $"SYM{i.ToString("D2")}", // e.g., SYM01, SYM02
                    CompanyName = $"Company Name {i}",
                    Purchase = 100.00m + (i * 10.50m), // Incremental purchase price
                    LastDiv = 0.10m + (i * 0.01m),     // Incremental dividend
                    Industry = i % 3 == 0 ? "Technology" : (i % 3 == 1 ? "Finance" : "Healthcare"), // Varying industry
                    MarketCap = 100000000000L + (long)(i * 10000000000L) // Incremental market cap
                });
            }

            modelBuilder.Entity<Stock>().HasData(stocks);
        }
    }
}