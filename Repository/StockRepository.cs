using AspApi.Data;
using AspApi.Helpers;
using AspApi.Interfaces;
using AspApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AspApi.Repository;

public class StockRepository : IStockInterface
{
    private readonly ApplicationDBContext _context;
    public StockRepository(ApplicationDBContext context)
    {
        _context=context;
        
    }
    public Task<List<Stock>> GetAllStocksAsync(QueryObjects query)
    {
        var stocks= _context.Stocks.Include(c=>c.Comments).AsQueryable();
        if (!string.IsNullOrWhiteSpace(query.CompanyName))
        {
            stocks = stocks.Where(c => c.CompanyName.Contains(query.CompanyName) );
        }
        
        if (!string.IsNullOrWhiteSpace(query.Symbol))
        {
            stocks = stocks.Where(c => c.Symbol.Contains(query.Symbol));
        }

        if (query.SortBy != null && query.SortBy.Equals("Symbol", StringComparison.OrdinalIgnoreCase))
        {
            stocks=query.IsDescending?stocks.OrderByDescending(c=>c.Symbol):stocks.OrderBy(c=>c.Symbol);
        }

        int skipCount = (query.PageNumber-1)*query.PageSize;
        stocks = stocks.Skip(skipCount).Take(query.PageSize);
        return Task.FromResult(stocks.ToList());
    }

    public async Task<Stock?> GetOneStock(int id)
    {
        return await _context.Stocks.FindAsync(id);
    }
    
}   