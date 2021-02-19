using System;
using System.IO;
using System.Linq;
using FoodGenerate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FoodGenerate.Db
{
    public class FoodDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Foods.Any())
                {
                    return;
                }

                context.Foods.AddRange(
                    new Food
                    {
                        FoodName = "Pizza",
                        Review = 9.5,
                        ImageData = GetImage("pizza.png", "image/png")
                    },
                    new Food
                    {
                        FoodName = "KFC",
                        Review = 9,
                        ImageData = GetImage("kfc.jpg", "image/jpg")
                    },
                    new Food
                    {
                        FoodName = "SomTam",
                        Review = 8.5,
                        ImageData = GetImage("somtam.jpg", "image/jpg")
                    },
                    new Food
                    {
                        FoodName = "Thai Basil",
                        Review = 10,
                        ImageData = GetImage("thai-basil.jpg", "image/jpg")
                    },
                    new Food
                    {
                        FoodName = "Pad Thai",
                        Review = 8.1,
                        ImageData = GetImage("padthai.jpg", "image/jpg")
                    },
                    new Food
                    {
                        FoodName = "Kang Keaw Wan",
                        Review = 8.5,
                        ImageData = GetImage("keawwan.jpg", "image/jpg")
                    },
                    new Food
                    {
                        FoodName = "Moo Ping",
                        Review = 9.5,
                        ImageData = GetImage("mooping.jpg", "image/jpg")
                    }
                );
                context.SaveChanges();
            }
        }

        private static string GetImage(string fileName, string fileType)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Db/Images", fileName);
            var imageBytes = File.ReadAllBytes(path);
            return $"data:{fileType};base64,{Convert.ToBase64String(imageBytes)}";
        }
    }
}