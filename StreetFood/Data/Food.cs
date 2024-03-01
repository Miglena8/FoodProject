using System.ComponentModel.DataAnnotations.Schema;

namespace StreetFood.Data
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public bool DietFood { get; set; }
        public int FoodCategoriesId { get; set; }
        public FoodCategory FoodCategories { get; set; }
        public int Ingredients { get; set; }
        public string Image { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;
        public ICollection<Order> Orders { get; set; }
    }
}
