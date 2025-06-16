using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspApi.Helpers;
using AspApi.Models;

namespace AspApi.Interfaces
{
    public interface IStockInterface
    {
        Task<List<Stock>> GetAllStocksAsync(QueryObjects query);
        Task<Stock> GetOneStock(int id);
    }
}