using System;
using AspApi.Data;
using AspApi.Dtos.Stock;
using AspApi.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace AspApi.Controllers
{

    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stocks = await _context.Stocks.ToListAsync();
             var stockDto=stocks.Select(stock => stock.ToStockDto()).ToList();
            return Ok(stockDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stocks.Find(id)?.ToStockDto();
      
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }


        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDto createStockRequest)
        {
            if (createStockRequest == null)
            {
                return BadRequest("Invalid stock data.");
            }

            var stock = createStockRequest.ToStock();
            _context.Stocks.Add(stock);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = stock.Id }, stock.ToStockDto());
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateStockRequestDto updateStockRequest)
        {
            if (updateStockRequest == null)
            {
                return BadRequest("Invalid stock data.");
            }

            var stock = _context.Stocks.Find(id);
            if (stock == null)
            {
                return NotFound();
            }
            stock = updateStockRequest.UpdateStock(stock);
            _context.Stocks.Update(stock);
            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var stock = _context.Stocks.FirstOrDefault(x=>x.Id==id);
            if (stock == null)
            {
                return NotFound();
            }

            _context.Stocks.Remove(stock);
            _context.SaveChanges();

            return NoContent();
        }

    }
}