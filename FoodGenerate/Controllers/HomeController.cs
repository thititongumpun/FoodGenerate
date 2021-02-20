using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FoodGenerate.Models;
using FoodGenerate.Db;
using FoodGenerate.Infrastucture.Services;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using Microsoft.Extensions.Options;

namespace FoodGenerate.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly RedisConfiguration _redis;
        private readonly IDistributedCache _cache;
        private readonly IRedisConnectionFactory _factory;

        public HomeController(AppDbContext context, IOptions<RedisConfiguration> redis, IDistributedCache cache, IRedisConnectionFactory factory)
        {
            _context = context;
            _redis = redis.Value;
            _cache = cache;
            _factory = factory;
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

        public IActionResult Vote()
        {
            var hello = Encoding.UTF8.GetBytes("Hello WOrld");
            HttpContext.Session.Set("hellokey", hello);

            var getHello = default(byte[]);
            HttpContext.Session.TryGetValue("hellokey", out getHello);
            ViewData["Hello"] = Encoding.UTF8.GetString(getHello);
            ViewData["SessionId"] = HttpContext.Session.Id;

            _cache.SetString("Cache", "this is redis cache");

            ViewData["Host"] =_redis.Host;
            ViewData["Port"] = _redis.Port;
            ViewData["Name"] = _redis.Name;

            ViewData["DistCache"] = _cache.GetString("CacheTest");

            var db = _factory.Connection().GetDatabase();
            db.StringSet("StackExchange.Redis.Key", "Stack Exchange Redis is Awesome");
            ViewData["StackExchange"] = db.StringGet("StackExchange.Redis.Key");

            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
