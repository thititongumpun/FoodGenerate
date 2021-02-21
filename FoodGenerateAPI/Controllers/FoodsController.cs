using System.Threading.Tasks;
using FoodGenerateAPI.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodGenerateAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FoodsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetFoods()
        {
            var foods = await _context.Foods.ToListAsync();
            return Ok(foods);
        }
    }
}