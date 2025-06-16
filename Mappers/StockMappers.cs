using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspApi.Dtos.Stock;
using AspApi.Models;

namespace AspApi.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stock)
        {
            return new StockDto
            {
                Id = stock.Id,
                Symbol = stock.Symbol,
                CompanyName = stock.CompanyName,
                Purchase = stock.Purchase,
                LastDiv = stock.LastDiv,
                Industry = stock.Industry,
                MarketCap = stock.MarketCap,
                Comments=stock.Comments.Select(c=> c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStock(this CreateStockRequestDto createStockRequest)
        {
            return new Stock
            {
                Symbol = createStockRequest.Symbol,
                CompanyName = createStockRequest.CompanyName,
                Purchase = createStockRequest.Purchase,
                LastDiv = createStockRequest.LastDiv,
                Industry = createStockRequest.Industry,
                MarketCap = createStockRequest.MarketCap,
                
            };
        }
        public static Stock UpdateStock(this UpdateStockRequestDto updateStockRequest, Stock existingStock)
        {
            existingStock.Symbol = updateStockRequest.Symbol;
            existingStock.CompanyName = updateStockRequest.CompanyName;
            existingStock.Purchase = updateStockRequest.Purchase;
            existingStock.LastDiv = updateStockRequest.LastDiv;
            existingStock.Industry = updateStockRequest.Industry;
            existingStock.MarketCap = updateStockRequest.MarketCap;

            return existingStock;
        }
    }
}