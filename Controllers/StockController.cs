using System;
using AspApi.Data;
using AspApi.Dtos.Stock;
using AspApi.Helpers;
using AspApi.Interfaces;
using AspApi.Mappers;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace AspApi.Controllers
{

    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IStockInterface _stockInterface;
        public StockController(ApplicationDBContext context,IStockInterface  stockInterface)
        {
            _stockInterface=stockInterface;
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] QueryObjects query)
        {
            var stocks = await _stockInterface.GetAllStocksAsync(query);
             var stockDto=stocks.Select(stock => stock.ToStockDto()).ToList();
            return Ok(stockDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var stock = await _stockInterface.GetOneStock(id);
      
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }


        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDto createStockRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
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
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStockRequestDto updateStockRequest)
        {
         

            var stock = await _context.Stocks.FindAsync(id);
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
        public IActionResult  Delete([FromRoute] int id)
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