using System.ComponentModel.DataAnnotations;

namespace FoodGenerate.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string FoodName { get; set; }
        public double Review {get;set;}
        public string ImageData {get;set;}
    }
}