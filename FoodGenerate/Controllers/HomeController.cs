using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FoodGenerate.Models;
using FoodGenerate.Db;

namespace FoodGenerate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Random r = new Random();
            var randomFood = _context.Foods.Skip(r.Next(0, _context.Foods.Count())).Take(1).FirstOrDefault();
            return View(randomFood);
        }

        public IActionResult FoodRankings()
        {
            var food = _context.Foods.OrderByDescending(f => f.Review).ToList();
            return View(food);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
