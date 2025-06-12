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
            modelBuilder.Entity<Stock>().HasData(
                new Stock 
                { 
                    Id = 1, 
                    Symbol = "AAPL", 
                    CompanyName = "Apple Inc.", 
                    Purchase = 150.00m, 
                    LastDiv = 0.22m, 
                    Industry = "Technology", 
                    MarketCap = 2500000000000 
                },
                new Stock 
                { 
                    Id = 2, 
                    Symbol = "MSFT", 
                    CompanyName = "Microsoft Corp.", 
                    Purchase = 250.00m, 
                    LastDiv = 0.56m, 
                    Industry = "Technology", 
                    MarketCap = 2000000000000 
                },
                new Stock 
                { 
                    Id = 3, 
                    Symbol = "TSLA", 
                    CompanyName = "Tesla Inc.", 
                    Purchase = 700.00m, 
                    LastDiv = 0.00m, 
                    Industry = "Automobile", 
                    MarketCap = 800000000000 
                }
            );
        }
    }
}