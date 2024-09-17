using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Pagination.DataAccess.Core;
using WebAPI_Pagination.DataAccess.Models;
using WebAPI_Pagination.Filter;
using WebAPI_Pagination.Wrappers;

namespace WebAPI_Pagination.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly AppContextFile _context;
        public ItemsController(AppContextFile appContextFile)
        {
            _context = appContextFile;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _context.Items.Where(a => a.Id == id).FirstOrDefaultAsync();
            return Ok(new Response<Item>(item));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _context.Items
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .ToListAsync();
            var totalRecords = await _context.Items.CountAsync();
            return Ok(new PagedResponse<List<Item>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
        }
    }
}
