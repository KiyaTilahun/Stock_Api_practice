using System;
using AspApi.Data;
using AspApi.Dtos.Comments;
using AspApi.Dtos.Stock;
using AspApi.Interfaces;
using AspApi.Mappers;
using AspApi.Models;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace AspApi.Controllers
{

    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly ICommentInterface _commentInterface;
        public CommentController(ApplicationDBContext context,ICommentInterface  commentInterface)
        {
            _commentInterface=commentInterface;
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentInterface.GetAllCommentsAsync();
             var commentDto=comments.Select(c=>c.ToCommentDto()).ToList();
            return Ok(commentDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var stock = await _commentInterface.GetOneComment(id);
      
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
        public async Task<IActionResult> Update([FromRoute]int id ,[FromBody]  UpdateCommentDto commentDto)
        {
            var comment = await _commentInterface.UpdateCommet(id,commentDto.ToUpdateComment());
            if (comment == null) 
            {
                return NotFound("Comment not found");
            }
            return Ok(comment.ToCommentDto());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var comment = await _commentInterface.GetOneComment(id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return NoContent();
        }


    }
}