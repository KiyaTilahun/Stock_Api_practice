using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspApi.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        private string _companyName = string.Empty;
        public string CompanyName
        {
            get => "Corp_" + _companyName; // Adds "Corp_" prefix to CompanyName
            set => _companyName = value;
        }
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
    }
}