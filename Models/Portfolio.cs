using System.ComponentModel.DataAnnotations.Schema;

namespace AspApi.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        public string UserId { get; set; }
        public int  StockId { get; set; }
        public Stock Stock { get; set; }
        public User User { get; set; }
    }
}
