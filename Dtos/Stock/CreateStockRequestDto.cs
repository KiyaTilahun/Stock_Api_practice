using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspApi.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        

        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Purchase price is required.")]
        [Range(0.01, 1000, ErrorMessage = "Purchase price must be between 0 and 1000 ")]
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }


    }
}