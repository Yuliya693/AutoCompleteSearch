using AutoCompleteSearch.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
public class SearchController : ControllerBase
{
    private readonly YourDbContext _context;

    public SearchController(YourDbContext context)
    {
        _context = context;
    }

    [HttpGet("Search")]
    public async Task<IActionResult> Search(string query)
    {
        var results = await _context.Items
            .Where(item => EF.Functions.Like(item.Name, $"%{query}%"))
            .ToListAsync();
        return Ok(results);
    }
}

